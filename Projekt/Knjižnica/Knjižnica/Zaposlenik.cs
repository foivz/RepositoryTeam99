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

        private void btnUnosAutora_Click(object sender, EventArgs e)
        {
            FrmUnosAutora unos = new FrmUnosAutora();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        private void btnUnosIzdavaca_Click(object sender, EventArgs e)
        {
            FrmUnosIzdavaca unos = new FrmUnosIzdavaca();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            FrmUnosKnjige unos = new FrmUnosKnjige();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        private void btnUnosLokacije_Click(object sender, EventArgs e)
        {
            FrmUnosLokacije unos = new FrmUnosLokacije();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        private void btnUnosZanra_Click(object sender, EventArgs e)
        {
            FrmUnosZanra unos = new FrmUnosZanra();
            unos.MdiParent = this;
            unos.StartPosition = FormStartPosition.Manual;
            unos.Show();
        }

        private void btnKnjigePoAutoru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoAutoru pretraživanje = new FrmKnjigaPoAutoru();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        private void btnKnjigePoZanru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoZanru pretraživanje = new FrmKnjigaPoZanru();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        private void btnKorIme_Click(object sender, EventArgs e)
        {
            FrmKorisnikKorIme pretraživanje = new FrmKorisnikKorIme();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        private void btnKnjigeLokacija_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNazivu pretraživanje = new FrmKnjigaPoNazivu();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        private void btnKnjigePoNaslovu_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNaslovu pretraživanje = new FrmKnjigaPoNaslovu();
            pretraživanje.MdiParent = this;
            pretraživanje.StartPosition = FormStartPosition.Manual;
            pretraživanje.Show();
        }

        private void btnClanarina_Click(object sender, EventArgs e)
        {
            FrmClanarina posudba = new FrmClanarina();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        private void btnPosudivanje_Click(object sender, EventArgs e)
        {
            FrmPosudba posudba = new FrmPosudba();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            Izrada_računa posudba = new Izrada_računa();
            posudba.MdiParent = this;
            posudba.StartPosition = FormStartPosition.Manual;
            posudba.Show();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
