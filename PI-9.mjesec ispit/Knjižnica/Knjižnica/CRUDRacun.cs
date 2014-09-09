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
    public partial class CRUDRacun : Form
    {
        public CRUDRacun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikaz podataka o racunu iz baze podataka
        /// </summary>
        /// 
        private void PrikaziRacun()
        {

            BindingList<racun> listaRacuna = null;
            using (var db = new piBazaEntities())
            {
                listaRacuna = new BindingList<racun>(db.racun.ToList());


            }
            racunBindingSource.DataSource = listaRacuna;
        }
        /// <summary>
        /// Na događaj "Load" pokrece funkciju PrikaziRacun
        /// </summary>
        /// <param name="sender">Referenca na formu CRUDRacun</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void CRUDRacun_Load(object sender, EventArgs e)
        {
            PrikaziRacun();
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje tablicu Racun iz baze podataka
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        
            {

                int pretrazi = int.Parse(txtSifraRacuna.Text);


                

                BindingList<racun> listaRacuna = null;
                using (var db = new piBazaEntities())
                {
                    var query = from c in db.racun where c.idRacuna == pretrazi select c;
                    listaRacuna = new BindingList<racun>(query.ToList());


                }
                racunBindingSource.DataSource = listaRacuna;
            }
        /// <summary>
        /// Na događaj "Click" brise podatke iz baze iz tablice Racun
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObris</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {

            racun odabraniRacun = racunBindingSource.Current as racun;
            if (odabraniRacun != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {

                        db.racun.Attach(odabraniRacun);
                        db.racun.Remove(odabraniRacun);
                        db.SaveChanges();

                    }

                    PrikaziRacun();
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {

        }
     
    }
}
