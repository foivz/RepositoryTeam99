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
    public partial class FrmKnjigaPoAutoru : Form
    {
        public FrmKnjigaPoAutoru()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Na događaj "Click"  pretrazuje knjigu po autoru
        /// </summary>
        /// <param name="sender">Referenca na gumb btn Pretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Pretrazi</param>
        /// 

        static int brojac;
        static int a;
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtAutorKnjige.Text;

            using (var db = new piBazaEntities())
            {
                var query = (from c in db.autorKnjige select c.id_zapisa).Count();
                brojac = query;
            }

            for (int i = 0; i < brojac; i++)
            {
                string z = dataGridView1.Rows[i].Cells[4].Value.ToString();
                if (z == pretrazi)
                    a = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());

                
            }

           
            BindingList<autorKnjige> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.autorKnjige where c.autor == a select c;
                listaKnjiga = new BindingList<autorKnjige>(query.ToList());


            }
            autorKnjigeBindingSource.DataSource = listaKnjiga;
            int cc = listaKnjiga.Count();
            int brojac7 = 0;
            int brojac8 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac7++].Cells[1].Value);
                    var query = from c in db.knjiga
                                where a == c.idKnjiga
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac8++].Cells[2].Value = c.naziv;

                }
            }
            int brojac3 = 0;
            int brojac4 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac3++].Cells[3].Value);
                    var query = from c in db.autor
                                where a == c.idAutora
                                select new
                                {
                                    c.ime,
                                    c.prezime

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac4++].Cells[4].Value = c.ime + ' ' + c.prezime;

                }
            }

            
        }
        /// <summary>
        /// Na događaj "Shown"  pokrece funkciju PrikaziKnjige
        /// </summary>
        /// <param name="sender">Referenca na formu FrmKnjigaPoAutoru</param>
        /// <param name="e">Dodatni podaci o događaju Shown</param>
        /// 
        private void FrmKnjigaPoAutoru_Shown(object sender, EventArgs e)
        {

            PrikaziKnjige();
        }

        /// <summary>
        /// Funkcija za prikaz podataka o knjizi
        /// </summary>
        /// 

        private void PrikaziKnjige()
        {

            BindingList<autorKnjige> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                listaKnjiga = new BindingList<autorKnjige>(db.autorKnjige.ToList());


            }
            autorKnjigeBindingSource.DataSource = listaKnjiga;
            int cc = listaKnjiga.Count();
            int brojac = 0;
            int brojac1 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[1].Value);
                    var query = from c in db.knjiga
                                where a == c.idKnjiga
                                select new
                                {
                                    c.naziv

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac1++].Cells[2].Value = c.naziv;

                }
            }
            int brojac3 = 0;
            int brojac4 = 0;
            for (int i = 0; i < cc; i++)
            {
                using (var db = new piBazaEntities())
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac3++].Cells[3].Value);
                    var query = from c in db.autor
                                where a == c.idAutora
                                select new
                                {
                                    c.ime,
                                    c.prezime

                                };
                    foreach (var c in query)
                        dataGridView1.Rows[brojac4++].Cells[4].Value = c.ime + ' ' + c.prezime;

                }
            }
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu za pretraživanje knjige po autoru
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
