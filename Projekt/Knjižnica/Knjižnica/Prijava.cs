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
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
        }


        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {
                var query = from korisnik in db.korisnik
                            select new
                            {
                                korime = korisnik.korisnickoIme,
                                lozinka = korisnik.lozinka,
                                tip = korisnik.tipKorisnika
                            };
                bool nadeno = false;
                foreach (var korisnik in query)
                {
                    if ((txtKorisnckoIme.Text == korisnik.korime) && (korisnik.lozinka == txtLozinka.Text) && (korisnik.tip == 1))
                    {
                        FrmRegistriraniKorisnik k1 = new FrmRegistriraniKorisnik();
                        k1.Show();
                        nadeno = true;

                    }
                    else if ((txtKorisnckoIme.Text == korisnik.korime) && (korisnik.lozinka == txtLozinka.Text) && (korisnik.tip == 2))
                    {
                        Zaposlenik z1 = new Zaposlenik();
                        z1.Show();
                        nadeno = true;

                    }





                }
                if (!nadeno)
                {
                    MessageBox.Show("Neispravan unos!");
                }
            }





            if (txtKorisnckoIme.Text == "")
            {

                MessageBox.Show("Niste unjeli korisničko ime!");
            }

            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!");
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija registracija = new FrmRegistracija();
            registracija.MdiParent = this.ParentForm;
            registracija.StartPosition = FormStartPosition.Manual;
            registracija.Show();
        }

       
    }
}