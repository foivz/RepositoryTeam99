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
    public partial class frmPregledSlobodnihKnjiga : Form
    {
        public frmPregledSlobodnihKnjiga()
        {
            InitializeComponent();
        }
        private void PrikaziKnjige()
        {

            BindingList<knjiga> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                listaKnjiga = new BindingList<knjiga>(db.knjiga.ToList());
            }
            knjigaBindingSource.DataSource = listaKnjiga;

        }
        private void PrikaziPosudbu(knjiga Knjiga)
        {
            BindingList<posudivanje> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                db.knjiga.Attach(Knjiga);
                listaKnjiga = new
                BindingList<posudivanje>(Knjiga.posudba.ToList<posudivanje>());
            }
            posudivanjeBindingSource.DataSource = listaKnjiga;
        }
        private void PregledSlobodnihKnjiga_Load(object sender, EventArgs e)
        {
            PrikaziKnjige();
            PrikaziPosudbu(knjigaBindingSource.Current as knjiga);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void PregledSlobodnihKnjiga_Shown(object sender, EventArgs e)
        {
            PrikaziKnjige();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            knjiga selektiraniZanr = knjigaBindingSource.Current as knjiga;
            if (selektiraniZanr != null)
            {
                PrikaziPosudbu(selektiraniZanr);
            }
        }

       
    }
}
