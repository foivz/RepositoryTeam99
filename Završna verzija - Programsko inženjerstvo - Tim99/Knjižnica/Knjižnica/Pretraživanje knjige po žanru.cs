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
    public partial class FrmKnjigaPoZanru : Form
    {
        public FrmKnjigaPoZanru()
        {
            InitializeComponent();
        }

      
        /// <summary>
        /// Funkcija za prikazivanje zanrova
        /// </summary>
        /// 
        private void PrikaziZanr()
        {

            BindingList<zanr> listaZanrova = null;
            using (var db = new piBazaEntities())
            {
                listaZanrova = new BindingList<zanr>(db.zanr.ToList());
            }
            zanrBindingSource.DataSource = listaZanrova;

        }
        /// <summary>
        /// Funkcija za prikazivanje knjiga
        /// 
        private void PrikaziKnjigu(zanr Zanr)
        {
            BindingList<knjiga> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                db.zanr.Attach(Zanr);
                listaKnjiga = new
                BindingList<knjiga>(Zanr.knjiga.ToList<knjiga>());
            }
            knjigaBindingSource.DataSource = listaKnjiga;
        }
        /// <summary>
        /// Na događaj "Load" priprema formu za unos podataka
        /// </summary>
        /// <param name="sender">Referenca na formu frmKnjigaPoZanru</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void FrmKnjigaPoZanru_Load(object sender, EventArgs e)
        {
            PrikaziZanr();
            PrikaziKnjigu(zanrBindingSource.Current as zanr);
        }
        /// <summary>
        /// Na događaj "SelectionChanged" puni dataGridView sa podacima o knjizi i zanru
        /// </summary>
        /// <param name="sender">Referenca na dataGridView dataGridView2</param>
        /// <param name="e">Dodatni podaci o događaju SelectionChanged</param>
        /// 
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
      
            {
                zanr selektiraniZanr = zanrBindingSource.Current as zanr;
                if (selektiraniZanr != null)
                {
                    PrikaziKnjigu(selektiraniZanr);
                }
            }
        static int pretr;
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtNazivŽanra.Text;
            using (var db = new piBazaEntities())
            {
                var query = from b in db.zanr
                            where b.naziv == pretrazi
                            select new
                            {
                                b.idZanr

                            };
                
                foreach ( var b in query )
                    pretr = b.idZanr;
            }
            
            BindingList<knjiga> listaKnjiga = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.knjiga where c.zanr == pretr select c;
                listaKnjiga = new BindingList<knjiga>(query.ToList());


            }
            knjigaBindingSource.DataSource = listaKnjiga;
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu za pretraživanje knjige po žanru
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
