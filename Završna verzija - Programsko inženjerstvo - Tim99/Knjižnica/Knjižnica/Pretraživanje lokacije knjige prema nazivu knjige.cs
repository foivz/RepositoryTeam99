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
    public partial class FrmKnjigaPoNazivu : Form
    {
        public FrmKnjigaPoNazivu()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Funkcija za prikazivanje popisa knjiga i njihovih lokacija
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
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[2].Value);
                    var query = from c in db.lokacijaKnjige
                                where a == c.idLokacije
                                select new
                                {
                                    c.kat,
                                    c.odjeljak,
                                    c.stalaza,
                                    c.polica

                                };
                    foreach (var c in query)
                    {
                        dataGridView1.Rows[brojac1].Cells[3].Value = c.kat;
                        dataGridView1.Rows[brojac1].Cells[4].Value = c.odjeljak;
                        dataGridView1.Rows[brojac1].Cells[5].Value = c.stalaza;
                        dataGridView1.Rows[brojac1].Cells[6].Value = c.polica;
                        brojac1++;
                    }
                }
            }
        }     
        private void FrmKnjigaPoNazivu_Load(object sender, EventArgs e)
        {

        }

        private void FrmKnjigaPoNazivu_Shown(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }
        /// <summary>
        /// Na događaj "Click" omogucuje pretrazivanje lokacije po nazivu knjige
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtNazivKnjige.Text;
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
                    int a = Convert.ToInt32(dataGridView1.Rows[brojac++].Cells[2].Value);
                    var query = from c in db.lokacijaKnjige
                                where a == c.idLokacije
                                select new
                                {
                                    c.kat,
                                    c.odjeljak,
                                    c.stalaza,
                                    c.polica

                                };
                    foreach (var c in query)
                    {
                        dataGridView1.Rows[brojac1].Cells[3].Value = c.kat;
                        dataGridView1.Rows[brojac1].Cells[4].Value = c.odjeljak;
                        dataGridView1.Rows[brojac1].Cells[5].Value = c.stalaza;
                        dataGridView1.Rows[brojac1].Cells[6].Value = c.polica;
                        brojac1++;
                    }
                }
            }
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu za pretraživanje knjige po lokaciji
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
