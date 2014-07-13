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
    public partial class FrmUnosIzdavaca : Form
    {
        public FrmUnosIzdavaca()
        {
            InitializeComponent();
        }
            private izdavac izdavacZaIzmjenu;
            public FrmUnosIzdavaca(izdavac i){
            InitializeComponent();
            izdavacZaIzmjenu = i;
        }

        /// <summary>
        /// Na događaj "Click" izlazi iz forme za unos izdavaca
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Na događaj "Click" upisuje podatke u bazu u tablicu "Izdavaci"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "".ToString() && txtAdresa.Text != "".ToString() && txtKontakt.Text != "".ToString())
            {
                MessageBox.Show("Uspješno ste unesli izdavača");
                {
                    using (var db = new piBazaEntities())
                    {
                        if (izdavacZaIzmjenu == null)
                        {


                            izdavac izd = new izdavac
                            {
                                naziv = txtNaziv.Text,
                                adresa = txtAdresa.Text,
                                kontakt = txtKontakt.Text

                            };

                            db.izdavac.Add(izd);
                            db.SaveChanges();
                        }
                        if (izdavacZaIzmjenu != null)
                        {
                            db.izdavac.Attach(izdavacZaIzmjenu);

                            izdavacZaIzmjenu.naziv = txtNaziv.Text;
                            izdavacZaIzmjenu.adresa = txtAdresa.Text;
                            izdavacZaIzmjenu.kontakt = txtKontakt.Text;
                            db.SaveChanges();
                        }

                        db.SaveChanges();
                    }
                    Close();
                }
            }
            else MessageBox.Show("Popunite polja");
        }
        private void FrmUnosIzdavaca_Load(object sender, EventArgs e)
        {
            txtNaziv.Focus();
            if (izdavacZaIzmjenu != null)
            {
                txtNaziv.Text = izdavacZaIzmjenu.naziv;
                txtAdresa.Text = izdavacZaIzmjenu.adresa;
                txtKontakt.Text = izdavacZaIzmjenu.kontakt;
            }
        }
       
    }
}
