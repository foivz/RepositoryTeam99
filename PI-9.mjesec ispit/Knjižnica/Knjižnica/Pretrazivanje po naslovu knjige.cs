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
    public partial class FrmKnjigaPoNaslovu : Form
    {
        public FrmKnjigaPoNaslovu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikazivanje podataka o knjizi
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
        /// Na događaj "Click"  zatvara formu za pretrazivanje knjige po naslovu
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Load"  pokrece funkciju PrikaziKnjige
        /// </summary>
        /// <param name="sender">Referenca na formu FrmKnjigaPoNaslovu</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void FrmKnjigaPoNaslovu_Load(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }
        /// <summary>
        /// Na događaj "Click"  pretrazuje knjigu po naslovu knjige
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
        /// Na događaj "Shown"  pokrece funkciju PrikaziKnjige
        /// </summary>
        /// <param name="sender">Referenca na formu FrmKnjigaPoAutoru</param>
        /// <param name="e">Dodatni podaci o događaju Shown</param>
        /// 
        private void FrmKnjigaPoNaslovu_Shown(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }
     
        
    }
}
