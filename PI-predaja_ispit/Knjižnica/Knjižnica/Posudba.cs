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
    public partial class FrmPosudba : Form
    {
        public FrmPosudba()
        {
            InitializeComponent();
        }
        private posudivanje posudbaZaIzmjenu;
        public FrmPosudba(posudivanje p)
        {
            InitializeComponent();
            posudbaZaIzmjenu = p;

        }
      
        static int a;
        static int b;
        static int posudi;
        string kol;
        static int trenutna;
        /// <summary>
        /// Na događaj "Click"  upisuje podatke u bazu u tablucu "Posudivanje"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosalji</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (cmbIme.Text != "".ToString() && cmbNaziv.Text != "".ToString() && dateTimePicker1.Text != "".ToString() && dateTimePicker2.Text != "".ToString())
            {
                MessageBox.Show("Uspješno ste napravili posudbu");
                using (var db = new piBazaEntities())
                {
                    var querry2 = from aa in db.korisnik
                                  where cmbIme.SelectedItem == aa.ime + " " + aa.prezime
                                  select new
                                  {
                                      aa.idKorisnika
                                  };
                    var querry3 = from bb in db.knjiga
                                  where cmbNaziv.SelectedItem == bb.naziv
                                  select new
                                  {
                                      bb.idKnjiga
                                  };

                    foreach (var aa in querry2)
                    {
                        a = aa.idKorisnika;


                    }
                    foreach (var bb in querry3)
                    {
                        b = bb.idKnjiga;


                    }

                    if (posudbaZaIzmjenu == null)
                    {
                        posudivanje pos = new posudivanje
                        {
                            korisnik = a,
                            knjiga = b,
                            datumPosudbe = dateTimePicker1.Value,
                            datumVracanja = dateTimePicker2.Value


                        };
                        {
                            var querry4 = from aa in db.knjiga
                                          where b == aa.idKnjiga
                                          select aa;


                            foreach (var aa in querry4)
                            {
                                aa.trenutnaKolicina = aa.trenutnaKolicina - 1;

                            }

                        }

                        db.posudba.Add(pos);
                        db.SaveChanges();
                    }
                    else
                    {
                        db.posudba.Attach(posudbaZaIzmjenu);
                        posudbaZaIzmjenu.korisnik = a;
                        posudbaZaIzmjenu.knjiga = b;
                        posudbaZaIzmjenu.datumPosudbe = dateTimePicker1.Value;
                        posudbaZaIzmjenu.datumVracanja = dateTimePicker2.Value;
                        db.SaveChanges();

                    }

                }


                Close();
            }
            else MessageBox.Show("Popunite polja");
        }
        /// <summary>
        /// Na događaj "Load"  priprema formu za unos podataka
        /// </summary>
        /// <param name="sender">Referenca na formu FrmPosudba</param>
        /// <param name="e">Dodatni podaci o događaju Load</param>
        /// 
        private void FrmPosudba_Load(object sender, EventArgs e)
        {
            cmbIme.Focus();
            if (posudbaZaIzmjenu != null)
            {
                cmbIme.Text = Convert.ToString(posudbaZaIzmjenu.korisnik);
                cmbNaziv.Text = Convert.ToString(posudbaZaIzmjenu.knjiga);
                dateTimePicker1.Value = Convert.ToDateTime(posudbaZaIzmjenu.datumPosudbe);
                dateTimePicker2.Value = Convert.ToDateTime(posudbaZaIzmjenu.datumVracanja);
            }
            using (var db = new piBazaEntities())
            {
                var querry = from a in db.korisnik
                             select new
                             {
                                 a.ime,
                                 a.prezime

                             };
                foreach (var a in querry)
                {
                    cmbIme.Items.Add(a.ime + " " + a.prezime);
                }
                var querry1 = from b in db.knjiga where b.trenutnaKolicina > 0
                              select new
                              {
                                  b.naziv
                              };
                foreach (var b in querry1)
                {

                    cmbNaziv.Items.Add(b.naziv);
                }

            }
        }
        /// <summary>
        /// Na događaj "Click"  zatvara formu za unos nove posudbe "frmPosudba"
        /// </summary>
        /// <param name="sender">Referenca gumbIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
