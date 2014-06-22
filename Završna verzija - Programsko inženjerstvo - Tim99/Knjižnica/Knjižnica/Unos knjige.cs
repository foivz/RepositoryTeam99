using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica
{
    public partial class FrmUnosKnjige : Form
    {
        public FrmUnosKnjige()
        {
            InitializeComponent();
        }
        static int lok;
        static int znr;
        static int izd;
        static int atr;

        /// <summary>
        /// Na događaj "Load" priprema formu "Unos knjige" za upisivanje podataka u bazu
        /// </summary>
        /// <param name="sender">Referenca na formu frmUnosKnjige</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void FrmUnosKnjige_Load(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {
                /////////////////////////////////////////////////////////
                int upit1 = (from a1 in db.knjiga select a1.idKnjiga).Count();
                upit1 += 1;
                txtSifraKnjige.Text = upit1.ToString();
                ////////////////////////////////////////////////////////////
                var upit2 = from a2 in db.autor
                            select new
                            {
                                a2.ime,
                                a2.prezime
                            };

                foreach (var a2 in upit2)
                {
                    cmbImeAutora.Items.Add(a2.ime + " " + a2.prezime);
                }
                ///////////////////////////////////////////////////////////////////////
                var upit3 = from a3 in db.izdavac
                            select new
                            {
                                a3.naziv,

                            };

                foreach (var a3 in upit3)
                {
                    cmbNazivIzdavaca.Items.Add(a3.naziv);
                }
               
                ///////////////////////////////////////////////////////////////////////
                var upit4 = from a4 in db.zanr
                            select new
                            {
                                a4.naziv,

                            };

                foreach (var a4 in upit4)
                {
                    cmbNazivZanra.Items.Add(a4.naziv);
                }

                ///////////////////////////////////////////////////////////////////////
                var upit5 = from a5 in db.lokacijaKnjige
                            select new
                            {
                                a5.idLokacije



                            };

                foreach (var a5 in upit5)
                {
                    cmbLokacija.Items.Add(a5.idLokacije);
                }

            }
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities()) {

                /////////////////////////////////////////////////////////////////////////////
                int a = Convert.ToInt16(cmbLokacija.SelectedItem);

                var upit6 = from a6 in db.lokacijaKnjige where a==a6.idLokacije select new
                          
                            {
                                
                                a6.idLokacije

                            };
               

                foreach (var a6 in upit6)
                {
                    lok = a6.idLokacije;

                }
               
                
                ///////////////////////////////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////////////////////////
               

                var upit7 = from a7 in db.zanr
                            where cmbNazivZanra.SelectedItem == a7.naziv
                            select new

                            {

                                a7.idZanr

                            };


                foreach (var a7 in upit7)
                {
                    znr = a7.idZanr;

                }


                ///////////////////////////////////////////////////////////////////////////////////
                var upit8 = from a8 in db.izdavac
                            where cmbNazivIzdavaca.SelectedItem == a8.naziv
                            select new

                            {

                                a8.idIzdavaca

                            };


                foreach (var a8 in upit8)
                {
                    izd = a8.idIzdavaca;

                }
                knjiga k = new knjiga
                {
                    idKnjiga=Convert.ToInt16(txtSifraKnjige.Text),
                    naziv=txtNazivKnjige.Text,
                    godinaIzdavanja=txtGodinaIzdavanja.Text,
                    izdavac=izd,
                    zanr=znr,
                    lokacijaKnjige=lok

                };
                db.knjiga.Add(k);
            
                ///////////////////////////////////////////////////////////////////////////////////
                var upit9 = from a9 in db.autor
                            where cmbImeAutora.SelectedItem == a9.ime+" "+a9.prezime
                            select new

                            {

                                a9.idAutora

                            };


                foreach (var a9 in upit9)
                {
                    atr = a9.idAutora;

                }
                
                /////////////////////////////////////////////////////
                autorKnjige ak = new autorKnjige
                {
                    knjiga = Convert.ToInt16(txtSifraKnjige.Text),
                    autor=atr

                };
                db.autorKnjige.Add(ak);
                db.SaveChanges();
            }
            Close();
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu za unos knjiga
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        }

    }

