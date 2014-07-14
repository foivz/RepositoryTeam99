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
    public partial class FrmUnosAutora : Form
    {
        public FrmUnosAutora()
        {
            InitializeComponent();
        }

        private autor autorZaIzmjenu;
        public FrmUnosAutora(autor aut)
        {
            InitializeComponent();
            autorZaIzmjenu = aut;
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu "Unos autora"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
              
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" salje podatke u bazu u tablicu "Autori"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "".ToString() && txtPrezime.Text != "".ToString())
            {
                MessageBox.Show("Uspješno ste unesli autora");
                {
                    using (var db = new piBazaEntities())
                    {
                        if (autorZaIzmjenu == null)
                        {

                            autor aut = new autor
                            {
                                ime = txtIme.Text,
                                prezime = txtPrezime.Text

                            };

                            db.autor.Add(aut);
                            db.SaveChanges();
                        }
                        if (autorZaIzmjenu != null)
                        {
                            db.autor.Attach(autorZaIzmjenu);

                            autorZaIzmjenu.ime = txtIme.Text;
                            autorZaIzmjenu.prezime = txtPrezime.Text;

                            db.SaveChanges();

                            

                        }
                        db.SaveChanges();
                    }
                    Close();
                }
            }
            else MessageBox.Show("Popunite polja");
        }
        private void FrmUnosAutora_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
            if (autorZaIzmjenu != null)
            {
                txtIme.Text = autorZaIzmjenu.ime;
                txtPrezime.Text = autorZaIzmjenu.prezime;

            }
        }
    }
}
