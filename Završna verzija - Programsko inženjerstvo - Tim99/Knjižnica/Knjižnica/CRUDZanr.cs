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
    public partial class CRUDZanr : Form
    {
        public CRUDZanr()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikazivanje podataka o zanru iz baze podataka
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
        /// Na događaj "Click" pretrazuje podatke iz baze o Zanru
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtZanr.Text;
            BindingList<zanr> listaZanrova = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.zanr where c.naziv == pretrazi select c;
                listaZanrova = new BindingList<zanr>(query.ToList());


            }
                zanrBindingSource.DataSource = listaZanrova;
        }
        /// <summary>
        /// Na događaj "Load" pretrazuje podatke iz baze o zanru
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDZanr</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void PretrazivanjeZanra_Load(object sender, EventArgs e)
        {
            PrikaziZanr();
        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDZanr
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke iz tablice Zanr iz baze podataka
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            zanr odabraniZanr = zanrBindingSource.Current as zanr;
            if (odabraniZanr != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.knjiga
                                    where odabraniZanr.idZanr == c.zanr
                                    select new
                                    {
                                        c.zanr

                                    };
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje žanra knjige (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0)
                        {
                            db.zanr.Attach(odabraniZanr);
                            db.zanr.Remove(odabraniZanr);
                            db.SaveChanges();
                        }

                    }

                    PrikaziZanr();
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            zanr selektiraniZanr = zanrBindingSource.Current as zanr;
            if (selektiraniZanr != null)
            {
                FrmUnosZanra forma = new FrmUnosZanra(selektiraniZanr);
                forma.MdiParent = this.ParentForm;
                forma.StartPosition = FormStartPosition.Manual;
                forma.Show();
                PrikaziZanr();


            }
        }
    }
}
