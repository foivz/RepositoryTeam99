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
    public partial class FrmRegistriraniKorisnik : Form
    {
        public FrmRegistriraniKorisnik()
        {
            InitializeComponent();
        }


        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKnjigaPoNaslovu_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNaslovu pretraživanje1 = new FrmKnjigaPoNaslovu();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void btnLokacijaKnjige_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNazivu pretraživanje1 = new FrmKnjigaPoNazivu();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void btnKnjigePoZanru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoZanru pretraživanje1 = new FrmKnjigaPoZanru();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void btnKnjigePoAutoru_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoAutoru pretraživanje1 = new FrmKnjigaPoAutoru();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }
    }
}
