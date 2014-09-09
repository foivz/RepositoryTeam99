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
    public partial class CRUDKnjiga : Form
    {
        public CRUDKnjiga()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Funkcija za prikaz podataka o knjizi iz baze iz tablice "Knjiga"
        /// </summary>
        /// 
        private void PrikaziKnjige()
        {

            BindingList<knjiga> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                listaKnjiga = new BindingList<knjiga>(db.knjiga.ToList());


            }
            knjigaBindingSource.DataSource = listaKnjiga;
            int cc = listaKnjiga.Count();
            int brojac = 0;
            int brojac1 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[3].Value);
                    var query = from c in db.zanr
                                where a == c.idZanr
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac1++].Cells[4].Value = c.naziv;

                }
            }
        }
        /// <summary>
        /// Na događaj "Click" pokrece funkciju PrikaziKnjige();
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDKnjiga</param>
        /// <param name="e">Dodatni podaci o događaju Shown</param>
        /// 
        private void CRUDKnjiga_Shown(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje knjigu prema nazivu knjige
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtNaslovKnjige.Text;
            BindingList<knjiga> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.knjiga where c.naziv == pretrazi select c;
                listaKnjiga = new BindingList<knjiga>(query.ToList());


            }
            knjigaBindingSource.DataSource = listaKnjiga;
            int cc = listaKnjiga.Count();
            int brojac = 0;
            int brojac1 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[3].Value);
                    var query = from c in db.zanr
                                where a == c.idZanr
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac1++].Cells[4].Value = c.naziv;

                }
            }
        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDKnjiga
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    
        /// <summary>
        /// Na događaj "Click" brise podatke o knjizi iz baze
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            int brojac2 = 0;
            knjiga odabranaKnjiga = knjigaBindingSource.Current as knjiga;
            if (odabranaKnjiga != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.posudba
                                    where odabranaKnjiga.idKnjiga == c.knjiga
                                    select new
                                    {
                                        c.korisnik

                                    };
                        var query2 = from c in db.autorKnjige
                                     where odabranaKnjiga.idKnjiga == c.knjiga
                                     select new
                                     {
                                         c.knjiga

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
                            MessageBox.Show("Nemoguće brisanje knjige (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0 && brojac2 == 0)
                        {
                            db.knjiga.Attach(odabranaKnjiga);
                            db.knjiga.Remove(odabranaKnjiga);
                            db.SaveChanges();
                        }
                    }

                    PrikaziKnjige();
                }
            }
        }

       
    }
}
