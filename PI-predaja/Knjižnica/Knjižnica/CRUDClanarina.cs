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
    public partial class CRUDClanarina : Form
    {
        public CRUDClanarina()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikaz podataka o clanarini iz baze
        /// </summary>
        /// 
        private void PrikaziClanarine()
        {

            BindingList<clanarina> listaClanarina = null;
            using (var db = new piBazaEntities())
            {
                listaClanarina = new BindingList<clanarina>(db.clanarina.ToList());
               
                
            }
            clanarinaBindingSource.DataSource = listaClanarina;
            int cc = listaClanarina.Count();
            int brojac = 0;
            int brojac1 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dgvClanarina.Rows[brojac++].Cells[4].Value);
                    var query = from c in db.korisnik
                                where a == c.idKorisnika
                                select new
                                {
                                    c.korisnickoIme

                                };
                    foreach (var c in query)
                        dgvClanarina.Rows[brojac1++].Cells[5].Value = c.korisnickoIme;

                }
            }
        }
        /// <summary>
        /// Na događaj "Shown" pokrece funckiju PrikaziClanarine
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDCLanarina</param>
        /// <param name="e">Dodatni podaci o događaju Shown</param>
        ///        
        
        private void CRUDClanarina_Shown(object sender, EventArgs e)
        {
            PrikaziClanarine();
        }

        private void CRUDClanarina_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDClanarina
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke iz tablice Clanarina
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            clanarina odabranaClanarina = clanarinaBindingSource.Current as clanarina;
            if (odabranaClanarina != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.racun
                                    where odabranaClanarina.idClanarina == c.clanarina
                                    select new
                                    {
                                        c.clanarina

                                    };
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje clanarine(koristi se u drugoj tablici)");
                        }

                        if (brojac == 0)
                        {
                            db.clanarina.Attach(odabranaClanarina);
                            db.clanarina.Remove(odabranaClanarina);
                            db.SaveChanges();
                        }

                    }

                    PrikaziClanarine();
                }
            }
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje tablica clanarine prema korisnickom imenu korisnika
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        static int brojac = 0;
        static int a;
        private void btnPretrazi_Click(object sender, EventArgs e)
        {


            string pretrazi = txtKorIme.Text;

            using (var db = new piBazaEntities())
            {
                var query = (from c in db.clanarina select c.idClanarina).Count();
                brojac = query;
            }

            for (int i = 0; i < brojac; i++)
            {
                string z = dgvClanarina.Rows[i].Cells[5].Value.ToString();
                if (z == pretrazi)
                    a = Convert.ToInt32(dgvClanarina.Rows[i].Cells[0].Value.ToString());




            }
            BindingList<clanarina> listaClanarina = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.clanarina where c.idClanarina == a select c;
                listaClanarina = new BindingList<clanarina>(query.ToList());


            }
            clanarinaBindingSource.DataSource = listaClanarina;

            int cc = listaClanarina.Count();
            int brojac5 = 0;
            int brojac1 = 0;
            int brojac2 = 0;
            int brojac3 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dgvClanarina.Rows[brojac5++].Cells[4].Value);
                    var query = from c in db.korisnik
                                where a == c.idKorisnika
                                select new
                                {
                                    c.korisnickoIme

                                };
                    foreach (var c in query)
                        dgvClanarina.Rows[brojac1++].Cells[5].Value = c.korisnickoIme;

                }
            }
        
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
