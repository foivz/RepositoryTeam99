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

        private void Button7_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoAutoru pretraživanje1 = new FrmKnjigaPoAutoru();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoZanru pretraživanje1 = new FrmKnjigaPoZanru();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNazivu pretraživanje1 = new FrmKnjigaPoNazivu();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            FrmKnjigaPoNazivu pretraživanje1 = new FrmKnjigaPoNazivu();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSlobodneKnjige_Click(object sender, EventArgs e)
        {
            frmPregledSlobodnihKnjiga pretraživanje1 = new frmPregledSlobodnihKnjiga();
            pretraživanje1.MdiParent = this;
            pretraživanje1.StartPosition = FormStartPosition.Manual;
            pretraživanje1.Show();
        }
    }
}
