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
    public partial class Zaposlenik : Form
    {
        public Zaposlenik()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Na događaj "Click" otvara izbornik zaposleniku "Uredi bazu"
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUrediBazu</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        
        private void btnUrediBazu_Click(object sender, EventArgs e)
        {
            IzbornikUrediBazu izbor = new IzbornikUrediBazu();
            izbor.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu frmUnosAutora
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUnosAutora</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        
        private void btnUnosAutora_Click(object sender, EventArgs e)
        {
            FrmUnosAutora unos = new FrmUnosAutora();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu frmUnosIzdavaca
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUnosIzdavaca</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        
        private void btnUnosIzdavaca_Click(object sender, EventArgs e)
        {
            FrmUnosIzdavaca unos = new FrmUnosIzdavaca();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu frmUnosKnjige
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUnosKnjige</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            FrmUnosKnjige unos = new FrmUnosKnjige();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu frmUnosLokacije
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUnosLokacije</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnUnosLokacije_Click(object sender, EventArgs e)
        {
            FrmUnosLokacije unos = new FrmUnosLokacije();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu frmUnosZanra
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUnosZanra</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnUnosZanra_Click(object sender, EventArgs e)
        {
            FrmUnosZanra unos = new FrmUnosZanra();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za pretrazivenje knjige po nazivu autora
        /// </summary>
        /// <param name="sender">Referenca na gumb btnUKnjigePoAutoru</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnKnjigePoAutoru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoAutoru pretraživanje = new FrmKnjigaPoAutoru();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za pretrazivanje knjige po zanru
        /// </summary>
        /// <param name="sender">Referenca na gumb btnKnjigePoZanru</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnKnjigePoZanru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoZanru pretraživanje = new FrmKnjigaPoZanru();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu pertaživanje lokacije po nazivu knjige
        /// </summary>
        /// <param name="sender">Referenca na gumb btnLokacija</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnLokacija_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNazivu pretraživanje = new FrmKnjigaPoNazivu();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za pretrazivanje knjige po njenom nazivu
        /// </summary>
        /// <param name="sender">Referenca na gumb btnKnjigaPoNaslovu</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnKnjigaPoNalsovu_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNaslovu pretraživanje = new FrmKnjigaPoNaslovu();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za unos clanarine 
        /// </summary>
        /// <param name="sender">Referenca na gumb btnClanarina</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnClanarina_Click(object sender, EventArgs e)
        {
            FrmClanarina posudba = new FrmClanarina();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za unos nove posudbe
        /// </summary>
        /// <param name="sender">Referenca na gumb btnPosudba</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnPosudba_Click(object sender, EventArgs e)
        {
            FrmPosudba posudba = new FrmPosudba();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        /// <summary>
        /// Na događaj "Click" otvara formu za kreiranje novog racuna
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzracun</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzracun_Click(object sender, EventArgs e)
        {
            frmIzradaRacuna posudba = new frmIzradaRacuna();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        /// <summary>
        /// Na događaj "Click" zatvara glavni izbornik
        /// </summary>
        /// <param name="sender">Referenca na gumb btnIzlaz</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPregledSlobodnihKnjiga posudba = new frmPregledSlobodnihKnjiga();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }
    }
}
