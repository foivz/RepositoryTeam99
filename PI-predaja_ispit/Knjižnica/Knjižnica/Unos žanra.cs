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
    public partial class FrmUnosZanra : Form
    {
        public FrmUnosZanra()
        {
            InitializeComponent();
        }
        private zanr zanrZaIzmjenu;
        public FrmUnosZanra(zanr zan)
        {
            InitializeComponent();
            zanrZaIzmjenu = zan;
        }

        /// <summary>
        /// Na događaj "Click" salje podatke u bazu u tablicu "Zanr"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "".ToString())
            {
                MessageBox.Show("Uspješno ste unesli žanr");
                {

                    using (var db = new piBazaEntities())
                    {
                        if (zanrZaIzmjenu == null)
                        {
                            zanr zn = new zanr
                            {


                                naziv = txtNaziv.Text

                            };


                            db.zanr.Add(zn);
                            db.SaveChanges();


                        }
                        if (zanrZaIzmjenu != null)
                        {
                            db.zanr.Attach(zanrZaIzmjenu);
                            zanrZaIzmjenu.naziv = txtNaziv.Text;

                            db.SaveChanges();
                        }

                    }
                    Close();
                }
            }
            else MessageBox.Show("Popunite polja");
        }

        /// <summary>
        /// Na događaj "Click" zatvara formu "Zanr"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUnosZanra_Load(object sender, EventArgs e)
        {
            txtNaziv.Focus();
            if (zanrZaIzmjenu != null)
            {
                txtNaziv.Text = zanrZaIzmjenu.naziv;

            }
        }

        
    }
}

     