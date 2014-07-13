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
    public partial class CRUDLokacija : Form
    {
        public CRUDLokacija()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikazivanje podataka o lokaciji iz baze podataka
        /// </summary>
        /// 
        private void PrikaziLokaciju()
        {

            BindingList<lokacijaKnjige> listaLokacija = null;
            using (var db = new piBazaEntities())
            {
                listaLokacija = new BindingList<lokacijaKnjige>(db.lokacijaKnjige.ToList());
            }
            lokacijaKnjigeBindingSource.DataSource = listaLokacija;

        }
        /// <summary>
        /// Na događaj "Load" pokrece funkciju PrikaziLokaciju
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDLokacija</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void PretrazivanjeLokacija_Load(object sender, EventArgs e)
        {
            PrikaziLokaciju();
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje tablicu lokacija po katu 
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            
               int pretrazi = int.Parse(txtPretraziLokaciju.Text);
           
           
            string pretr = txtPretraziLokaciju.Text;

            BindingList<lokacijaKnjige> listaLokacija = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.lokacijaKnjige where c.kat == pretrazi select c;
                listaLokacija = new BindingList<lokacijaKnjige>(query.ToList());


            }
            lokacijaKnjigeBindingSource.DataSource = listaLokacija;
        }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDLokacij
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke iz tablice lokacija iz baze
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            lokacijaKnjige odabranaLokacija = lokacijaKnjigeBindingSource.Current as lokacijaKnjige;
            if (odabranaLokacija != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.knjiga
                                    where odabranaLokacija.idLokacije == c.lokacijaKnjige
                                    select new
                                    {
                                        c.lokacijaKnjige

                                    };
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje lokacije knjige (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0)
                        {
                            db.lokacijaKnjige.Attach(odabranaLokacija);
                            db.lokacijaKnjige.Remove(odabranaLokacija);
                            db.SaveChanges();
                        }
                    }

                    PrikaziLokaciju();
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            lokacijaKnjige selektiranaLokacija = lokacijaKnjigeBindingSource.Current as lokacijaKnjige;
            if (selektiranaLokacija != null)
            {
                FrmUnosLokacije forma = new FrmUnosLokacije(selektiranaLokacija);
                forma.MdiParent = this.ParentForm;
                forma.StartPosition = FormStartPosition.Manual;
                forma.Show();
                PrikaziLokaciju();
                Close();


            }
        }
    }
}
