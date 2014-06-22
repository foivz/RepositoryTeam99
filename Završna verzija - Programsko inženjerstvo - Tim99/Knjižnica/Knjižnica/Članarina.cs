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
    public partial class FrmClanarina : Form
    {
        public FrmClanarina()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Na događaj "Load"  priprema podatke za upis u tablicu Clanarina
        /// </summary>
        /// <param name="sender">Referenca na formu FrmClanarina</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void FrmClanarina_Load(object sender, EventArgs e)
        {
            {
                using (var db = new piBazaEntities())
                {
                    var querry = from k in db.korisnik
                                 select new
                                 {
                                     ime = k.ime,
                                     prezime = k.prezime,
                                     korime = k.korisnickoIme
                                 };
                    foreach (var k in querry)
                    {
                        cmbKorisnickoIme.Items.Add(k.korime);
                       
                    }
                }
            }
        }
        /// <summary>
        /// Na događaj "Click"  zatvara formu za unos clanarina "Clanarina"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" upisuje podatke u bazu u tablicu "Clanarina"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {

            using (var db = new piBazaEntities())
            {
               

                var querry = from c in db.korisnik
                             where cmbKorisnickoIme.SelectedItem == c.korisnickoIme
                             select new
                             {
                                 c.idKorisnika

                             };

                foreach (var c in querry)
                {
                    
                    clanarina cl = new clanarina

                    {

                        idClanarina = 100,
                        cijena = 100,
                        datumPlacanja = dtpDatumPlacanja.Value,
                        datumIsteka = dtpDatumIsteka.Value,
                        korisnik = c.idKorisnika

                    };

                    db.clanarina.Add(cl);
                    db.SaveChanges();

                }
                Close();
            }


        }

        private void cmbKorisnickoIme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Na događaj "SelectedValueChanged" puni combobox sa podacima iz baze
        /// </summary>
        /// <param name="sender">Referenca na combobox cmbKorisnickoImes</param>
        /// <param name="e">Dodatni podaci o događaju SelectedValueChanged</param>
        /// 
        private void cmbKorisnickoIme_SelectedValueChanged(object sender, EventArgs e)
        {
            using (var db = new piBazaEntities())
            {
                var querry = from a in db.korisnik
                             where a.korisnickoIme == cmbKorisnickoIme.SelectedItem
                             select new
                             {
                                 a.ime,
                                 a.prezime

                             };

                foreach (var a in querry)
                {
                    txtNazivKor.Text = a.ime + " " + a.prezime;
                }

            }
        }
        static int k = 1;
        /// <summary>
        /// Na događaj "SelectedValueChanged"  na click prikazuje podatke iz baze za navedeni combobox
        /// </summary>
        /// <param name="sender">Referenca na combobox cmbKorisnickoIme</param>
        /// <param name="e">Dodatni podaci o događaju SelectedValueChanged</param>
        /// 
        private void cmbKorisnickoIme_Click(object sender, EventArgs e)
        {
            {
                using (var db = new piBazaEntities())
                {
                    var querry = from k in db.korisnik
                                 select new
                                 {
                                     ime = k.ime,
                                     prezime = k.prezime,
                                     korime = k.korisnickoIme
                                 };
                    foreach (var k in querry)
                    {
                       
                        txtNazivKor.Text = (k.ime + " " + k.prezime);
                    }
                }
            }
        }

    }
}
