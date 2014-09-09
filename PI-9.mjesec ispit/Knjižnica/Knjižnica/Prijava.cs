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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Na događaj "Click" otvara odgovarajuci izbornik za prijavljenog korisnika
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            FrmRegistracija registracija = new FrmRegistracija();
            registracija.MdiParent = this.ParentForm;
            registracija.StartPosition = FormStartPosition.Manual;
            registracija.Show();
          
        }

        /// <summary>
        /// Na događaj "Click" provjerava podatke o korisniku i na temelju toga otvara odgovarajuci izbornik
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 

        private void btnPosalji_Click_1(object sender, EventArgs e)
        {
            
            using (var db = new piBazaEntities())
            {
                var query = from korisnik in db.korisnik
                            select new
                            {
                                korime = korisnik.korisnickoIme,
                                lozinka=korisnik.lozinka,
                                tip=korisnik.tipKorisnika
                            };
                bool nadeno = false;
                foreach (var korisnik in query)
                {
                    if ((txtKorisnckoIme.Text == korisnik.korime) && (korisnik.lozinka == txtLozinka.Text)&&(korisnik.tip==1))
                    {
                        Zaposlenik k1 = new Zaposlenik();
                        k1.Show();
                        nadeno=true;
                       
                    }
                    else if ((txtKorisnckoIme.Text == korisnik.korime) && (korisnik.lozinka == txtLozinka.Text) && (korisnik.tip == 2))
                    {
                        FrmRegistriraniKorisnik z1 = new FrmRegistriraniKorisnik();
                        z1.Show();
                        nadeno = true;
                        
                    }
                   
                  
                  

                   
                }
                if (!nadeno)
                {
                    MessageBox.Show("Neispravan unos!");
                }
            }

          
            
           
            
            if (txtKorisnckoIme.Text == "") {

                MessageBox.Show("Niste unjeli korisničko ime!");
            }

            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!");
            }
         
            
               
        
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za registraciju korisnika frmRegistracija
        /// </summary>
        /// <param name="sender">Referenca na gumb btnRegistracija</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FrmRegistracija regis = new FrmRegistracija();
            regis.MdiParent = this.ParentForm;
            regis.StartPosition = FormStartPosition.Manual;
            regis.Show();
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu "Prijava"
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
