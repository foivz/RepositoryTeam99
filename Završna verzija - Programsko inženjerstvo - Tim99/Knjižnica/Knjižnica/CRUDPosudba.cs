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
    public partial class CRUDPosudba : Form
    {
        public CRUDPosudba()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikaz podataka o posudbi iz baze podataka
        /// </summary>
        /// 
        private void PrikaziPosudbu()
        {

            BindingList<posudivanje> listaPosudbi = null;
            using (var db = new piBazaEntities())
            {
                listaPosudbi = new BindingList<posudivanje>(db.posudba.ToList());
            }
            posudivanjeBindingSource.DataSource = listaPosudbi;
            int cc = listaPosudbi.Count();
            int brojac = 0;
            int brojac1 = 0;
            int brojac2 = 0;
            int brojac3 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[1].Value);
                    var query = from c in db.korisnik
                                where a == c.idKorisnika
                                select new
                                {
                                    c.korisnickoIme

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac1++].Cells[2].Value = c.korisnickoIme;

                }
            }
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac2++].Cells[3].Value);
                    var query = from c in db.knjiga
                                where a == c.idKnjiga
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac3++].Cells[4].Value = c.naziv;

                }
            }

        }
        /// <summary>
        /// Na događaj "Shown" pokrece funckiju PrikaziPosudbu
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDPosudba</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void CRUDPosudba_Shown(object sender, EventArgs e)
        {
            PrikaziPosudbu();
        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDPosudba
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke iz baze o posudbi
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {

            posudivanje odabranoPosudivanje = posudivanjeBindingSource.Current as posudivanje;
            if (odabranoPosudivanje != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {

                        db.posudba.Attach(odabranoPosudivanje);
                        db.posudba.Remove(odabranoPosudivanje);
                        db.SaveChanges();

                    }

                    PrikaziPosudbu();
                }
            }
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje podatke iz baze iz tablice posudba
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        static int brojac = 0;
        static int a;
        private void btnPretrazi_Click(object sender, EventArgs e)
        {


            string pretrazi = txtKorisnik.Text;

            using (var db = new piBazaEntities())
            {
                var query = (from c in db.posudba select c.idPosudbe).Count();
                brojac = query;
            }

            for (int i = 0; i < brojac; i++)
            {
                string z = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (z == pretrazi)
                    a = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());




            }
            BindingList<posudivanje> listaPosudbi = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.posudba where c.idPosudbe == a select c;
                listaPosudbi = new BindingList<posudivanje>(query.ToList());


            }
            posudivanjeBindingSource.DataSource = listaPosudbi;
            int cc = listaPosudbi.Count();
            int brojac5 = 0;
            int brojac1 = 0;
            int brojac2 = 0;
            int brojac3 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac5++].Cells[1].Value);
                    var query = from c in db.korisnik
                                where a == c.idKorisnika
                                select new
                                {
                                    c.korisnickoIme

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac1++].Cells[2].Value = c.korisnickoIme;

                }
            }
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac2++].Cells[3].Value);
                    var query = from c in db.knjiga
                                where a == c.idKnjiga
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac3++].Cells[4].Value = c.naziv;

                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            posudivanje selektiranaPosudba = posudivanjeBindingSource.Current as posudivanje;
            if (selektiranaPosudba != null)
            {


                FrmPosudba f = new FrmPosudba(selektiranaPosudba);
                f.ShowDialog();
                PrikaziPosudbu();



            }






        }
    }
}
