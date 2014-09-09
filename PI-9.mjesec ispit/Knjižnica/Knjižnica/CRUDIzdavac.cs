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
    public partial class CRUDIzdavac : Form
    {
        public CRUDIzdavac()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funkcija za prikaz podataka o izdavacu iz baze
        /// </summary>
        /// 
        private void PrikaziIzdavaca()
        {

            BindingList<izdavac> listaIzdavaca = null;
            using (var db = new piBazaEntities())
            {
                listaIzdavaca = new BindingList<izdavac>(db.izdavac.ToList());
            }
            izdavacBindingSource.DataSource = listaIzdavaca;

        }
        /// <summary>
        /// Na događaj "Load" pokrece funkciju PrikaziIzdavaca
        /// </summary>
        /// <param name="sender">Referenca na formu PretrazivanjeIzdavaca</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void PretraživanjeIzdavaca_Load(object sender, EventArgs e)
        {
            PrikaziIzdavaca();
        }
        /// <summary>
        /// Na događaj "Click" pretrazuje izdavace prema nazivu izdavaca
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPretrazi</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPretrazi_Click(object sender, EventArgs e)
       
            {
                string pretrazi = txtIzdavac.Text;
                BindingList<izdavac> listaIzdavaca = null;
                using (var db = new piBazaEntities())
                {
                    var query = from c in db.izdavac where c.naziv == pretrazi select c;
                    listaIzdavaca = new BindingList<izdavac>(query.ToList());


                }
                izdavacBindingSource.DataSource = listaIzdavaca;
            }
        /// <summary>
        /// Na događaj "Click" izlazi iz forme CRUDIzdavac
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Na događaj "Click" brise podatke iz tablice Izdavaci
        /// </summary>
        /// <param name="sender">Referenca na gumb btnObris</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            izdavac odabraniIzdavac = izdavacBindingSource.Current as izdavac;
            if (odabraniIzdavac != null)
            {
                if (MessageBox.Show("Da li ste sigurni?",
                    "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new piBazaEntities())
                    {
                        var query = from c in db.knjiga
                                    where odabraniIzdavac.idIzdavaca == c.izdavac
                                    select new
                                    {
                                        c.izdavac

                                    };
                        foreach (var m in query)
                        {
                            brojac = brojac + 1;

                        }
                        if (brojac != 0)
                        {
                            MessageBox.Show("Nemoguće brisanje izdavaca knjige (koristi se u drugoj tablici)");
                        }

                        if (brojac == 0)
                        {
                            db.izdavac.Attach(odabraniIzdavac);
                            db.izdavac.Remove(odabraniIzdavac);
                            db.SaveChanges();
                        }
                    }

                    PrikaziIzdavaca();
                }
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            izdavac selektiraniIzdavac = izdavacBindingSource.Current as izdavac;
            if (selektiraniIzdavac != null)
            {
                FrmUnosIzdavaca forma = new FrmUnosIzdavaca(selektiraniIzdavac);
                forma.MdiParent = this.ParentForm;
                forma.StartPosition = FormStartPosition.Manual;
                forma.Show();
                PrikaziIzdavaca();
                Close();


            }
        }

        
        
    }
}
