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
    public partial class CRUDKorisnik : Form
    {
        public CRUDKorisnik()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikazivanje podataka iz baze o korisnicima
        /// </summary>
        /// 
        private void PrikaziKorisnika()
        {

            BindingList<korisnik> listaKorisnika = null;
            using (var db = new piBazaEntities())
            {
                listaKorisnika = new BindingList<korisnik>(db.korisnik.ToList());
            }
            korisnikBindingSource.DataSource = listaKorisnika;
            

        }

        /// <summary>
        /// Na događaj "Shown" pokrece funkciju PrikaziKorisnika
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDKorisnik</param>
        /// <param name="e">Dodatni podaci o događaju Shown</param>
        /// 
        private void CRUDKorisnik_Shown(object sender, EventArgs e)
        {
            PrikaziKorisnika();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtKorIme.Text;
            BindingList<korisnik> listaKorisnika = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.korisnik where c.korisnickoIme == pretrazi select c;
                listaKorisnika = new BindingList<korisnik>(query.ToList());


            }
            korisnikBindingSource.DataSource = listaKorisnika;
        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDKorisnik
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke o korisniku iz baze podataka
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            int brojac2 = 0;
            korisnik odabraniKorisnik = korisnikBindingSource.Current as korisnik;
            if (odabraniKorisnik != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.posudba
                                    where odabraniKorisnik.idKorisnika == c.korisnik
                                    select new
                                    {
                                        c.korisnik

                                    };
                        var query2 = from c in db.clanarina
                                     where odabraniKorisnik.idKorisnika == c.korisnik
                                     select new
                                     {
                                         c.korisnik

                                     };
                        foreach (var m in query2)
                        {
                            brojac2 = brojac2 + 1;

                        }
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0 || brojac2 != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje korisnika (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0 && brojac2 == 0)
                        {
                            db.korisnik.Attach(odabraniKorisnik);
                            db.korisnik.Remove(odabraniKorisnik);
                            db.SaveChanges();
                        }
                    }

                    PrikaziKorisnika();
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            korisnik selektiraniKorisnik = korisnikBindingSource.Current as korisnik;
            if (selektiraniKorisnik != null)
            {
                FrmRegistracija registracija = new FrmRegistracija(selektiraniKorisnik);
                registracija.MdiParent = this.ParentForm;
                registracija.StartPosition = FormStartPosition.Manual;
                registracija.Show();
                PrikaziKorisnika();


            }
        }
    }
}
