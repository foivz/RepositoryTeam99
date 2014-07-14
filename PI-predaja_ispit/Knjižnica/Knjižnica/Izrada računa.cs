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
    public partial class frmIzradaRacuna : Form
    {
        public frmIzradaRacuna()
        {
            InitializeComponent();
        }
      
        /// <summary>
        /// Na događaj "Load"  priprema podatke za upisu u bazu
        /// </summary>
        /// <param name="sender">Referenca na formu FrmIzradaRacuna</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void frmIzradaRacuna_Load(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {
                var querry = from k in db.clanarina
                             select new
                             {
                                 clanarina = k.idClanarina
                             };
                foreach (var k in querry)
                {
                    cmbSifraClanarine.Items.Add(k.clanarina);

                }
            }

            this.rptViewer.RefreshReport();
        }
        /// <summary>
        /// Na događaj "SelectedIndexChanged"  input sa podacimas
        /// </summary>
        /// <param name="sender">Referenca na combobox cmbSifraClanarine</param>
        /// <param name="e">Dodatni podaci o događaju SelectedIndexChanged</param>
        /// 
        private void cmbSifraClanarine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(cmbSifraClanarine.SelectedItem);
            
            using (var db = new piBazaEntities())
            {
                var querry11 = from kk in db.clanarina
                               where kk.idClanarina == a
                               select new
                               {
                                   cijena = kk.cijena
                               };
                foreach (var kk in querry11)
                {

                    txtUkupnaCijena.Text = Convert.ToString((kk.cijena));
                }
            }
        }
        /// <summary>
        /// Na događaj "Click"  salje podatke u bazu u tablicu "Racun"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {



                racun r = new racun
                {
                    clanarina = Convert.ToInt16(cmbSifraClanarine.SelectedItem),
                    vrijemeIzdavanja = dateTimePicker1.Value,
                    ukupnaCijena = Convert.ToInt16(txtUkupnaCijena.Text)


                };
                db.racun.Add(r);
                db.SaveChanges();


            }
            this.racunTableAdapter.Fill(this.piBazaDataSet.racun, Convert.ToInt16(cmbSifraClanarine.SelectedItem));
            this.rptViewer.RefreshReport();
            //Close();


        }
        /// <summary>
        /// Na događaj "Click"  zatvara formu za kreiranje racuna
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

