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
    public partial class CRUDAutor : Form
    {
        public CRUDAutor()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikaz autora
        /// </summary>
        /// 
        private void PrikaziAutora()
        {

            BindingList<autor> listaAutora = null;
            using (var db = new piBazaEntities())
            {
                listaAutora = new BindingList<autor>(db.autor.ToList());
            }
            autorBindingSource.DataSource = listaAutora;

        }
        /// <summary>
        /// Na događaj "Load" pokrece funkciju "PrikaziAutora"
        /// </summary>
        /// <param name="sender">Referenca na formu CrudAutor</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void CrudAutor_Load(object sender, EventArgs e)
        {
            PrikaziAutora();
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje bazu prema nazivu autora
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pretrazi = txtNazivAutora.Text;
            BindingList<autor> listaAutora = null;
            using (var db = new piBazaEntities())
            {
                var query = from c in db.autor where c.ime + " " + c.prezime == pretrazi select c;
                listaAutora = new BindingList<autor>(query.ToList());


            }
            autorBindingSource.DataSource = listaAutora;
        }
        /// <summary>
        /// Na događaj "Click" zatvara formu CRUDAutor
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brisi podatke iz tablice Autori
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObrisi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            autor odabraniAutor = autorBindingSource.Current as autor;
            if (odabraniAutor != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.autorKnjige
                                    where odabraniAutor.idAutora == c.autor
                                    select new
                                    {
                                        c.autor

                                    };
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje autora knjige (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0)
                        {
                            db.autor.Attach(odabraniAutor);
                            db.autor.Remove(odabraniAutor);
                            db.SaveChanges();
                        }
                    }

                    PrikaziAutora();
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            autor selektiraniAutor = autorBindingSource.Current as autor;
            if (selektiraniAutor != null)
            {
                FrmUnosAutora forma = new FrmUnosAutora(selektiraniAutor);
                forma.MdiParent = this.ParentForm;
                forma.StartPosition = FormStartPosition.Manual;
                forma.Show();
                PrikaziAutora();


            }
        }
    }
}
