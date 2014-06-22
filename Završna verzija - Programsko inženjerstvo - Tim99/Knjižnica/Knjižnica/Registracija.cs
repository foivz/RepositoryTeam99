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
    public partial class FrmRegistracija : Form
    {
        public FrmRegistracija()
        {
            InitializeComponent();
        }
        private korisnik korisnikZaIzmjenu;
        public FrmRegistracija(korisnik k)
        {
            InitializeComponent();
            korisnikZaIzmjenu = k;

        }
        int tip;
        /// <summary>
        /// Na događaj "Load" priprema formu registracija za unos podataka
        /// </summary>
        /// <param name="sender">Referenca na formu FrmRegistracija</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 

        private void FrmRegistracija_Load(object sender, EventArgs e)
       
            {
                {
                   
                    txtIme.Focus();
                    if (korisnikZaIzmjenu != null)
                    {
                        using (var db = new piBazaEntities())
                        {
                            var querry10 = from v in db.tipKorisnika
                                           select new
                                           {
                                               v.idTip

                                           };
                            foreach (var v in querry10)
                            {
                                cmbTipKorisnika.Items.Add(v.idTip);


                            }
                        }
                        txtIme.Text = korisnikZaIzmjenu.ime;
                        txtPrezime.Text = korisnikZaIzmjenu.prezime;
                        txtKorisnickoIme.Text = korisnikZaIzmjenu.korisnickoIme;
                        txtLozinka.Text = korisnikZaIzmjenu.lozinka;
                        txtOib.Text = korisnikZaIzmjenu.oib;
                        txtEmail.Text = korisnikZaIzmjenu.email;
                        txtBrojTelefona.Text = korisnikZaIzmjenu.brojTelefona;
                        cmbTipKorisnika.Text = Convert.ToString(korisnikZaIzmjenu.tipKorisnika);
                    }


                }
                if (korisnikZaIzmjenu == null)
                {
                    using (var db = new piBazaEntities())
                    {
                        var querry = from a in db.tipKorisnika
                                     select new
                                     {

                                         a.naziv
                                     };
                        foreach (var a in querry)
                        {
                            cmbTipKorisnika.Items.Add(a.naziv);
                        }

                    }
                }

            }
        /// <summary>
        /// Na događaj "Click" upisuje podatke u bazu u tablicu "Korisici"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {
                var querry = from b in db.tipKorisnika
                             where cmbTipKorisnika.SelectedItem == b.naziv
                             select new
                             {
                                 b.idTip
                             };
                if (korisnikZaIzmjenu == null)
                {
                    foreach (var b in querry)
                    {
                        korisnik kr = new korisnik
                        {

                            ime = txtIme.Text,
                            prezime = txtPrezime.Text,
                            korisnickoIme = txtKorisnickoIme.Text,
                            lozinka = txtLozinka.Text,
                            oib = txtOib.Text,
                            email = txtEmail.Text,
                            brojTelefona = txtBrojTelefona.Text,
                            tipKorisnika = b.idTip
                        };
                        db.korisnik.Add(kr);
                        db.SaveChanges();
                    }
                }
                else
                {
                    db.korisnik.Attach(korisnikZaIzmjenu);
                    korisnikZaIzmjenu.ime = txtIme.Text;
                    korisnikZaIzmjenu.prezime = txtPrezime.Text;
                    korisnikZaIzmjenu.korisnickoIme = txtKorisnickoIme.Text;
                    korisnikZaIzmjenu.lozinka = txtLozinka.Text;
                    korisnikZaIzmjenu.oib = txtOib.Text;
                    korisnikZaIzmjenu.email = txtEmail.Text;
                    korisnikZaIzmjenu.brojTelefona = txtBrojTelefona.Text;
                    korisnikZaIzmjenu.tipKorisnika = Convert.ToInt32(cmbTipKorisnika.SelectedItem);
                    db.SaveChanges();

                }
                Close();
            }
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu "Registracija"
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
