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
    public partial class FrmUnosLokacije : Form
    {
        public FrmUnosLokacije()
        {
            InitializeComponent();
        }
        private lokacijaKnjige lokacijaZaIzmjenu;
        public FrmUnosLokacije(lokacijaKnjige lok)
        {
            InitializeComponent();
            lokacijaZaIzmjenu = lok;
        }
        /// <summary>
        /// Na događaj "Click"  upisuje podatke u bazu u tablicu "Lokacija knjige"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
       
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            {
                using (var db = new piBazaEntities())
                {
                    if (lokacijaZaIzmjenu == null)
                    {
                        lokacijaKnjige lok = new lokacijaKnjige
                        {
                            kat = int.Parse(txtKat.Text),
                            odjeljak = txtOdjeljak.Text,
                            polica = txtPolica.Text,
                            stalaza = txtStalaza.Text

                        };

                        db.lokacijaKnjige.Add(lok);
                        db.SaveChanges();
                    }
                    if (lokacijaZaIzmjenu != null)
                    {
                        db.lokacijaKnjige.Attach(lokacijaZaIzmjenu);

                        lokacijaZaIzmjenu.kat = int.Parse(txtKat.Text);
                        lokacijaZaIzmjenu.odjeljak = txtOdjeljak.Text;
                        lokacijaZaIzmjenu.stalaza = txtStalaza.Text;
                        lokacijaZaIzmjenu.polica = txtPolica.Text;
                        db.SaveChanges();


                    }
                    db.SaveChanges();
                }
                Close();
            }
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu "Unos lokacije"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUnosLokacije_Load(object sender, EventArgs e)
        {
            txtKat.Focus();
            if (lokacijaZaIzmjenu != null)
            {
                txtKat.Text = lokacijaZaIzmjenu.kat.ToString();
                txtOdjeljak.Text = lokacijaZaIzmjenu.odjeljak;
                txtStalaza.Text = lokacijaZaIzmjenu.stalaza;
                txtPolica.Text = lokacijaZaIzmjenu.polica;


            }
        }

       
    }
}
