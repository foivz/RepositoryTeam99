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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Na događaj "Click"  otvara formu za prijavu "Prijava"
        /// </summary>
        /// <param name="sender">Referenca na gumb Button_1</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void Button1_Click(object sender, EventArgs e)
        {
          
            frmPrijava prijava = new frmPrijava();
            prijava.MdiParent = this;
            prijava.StartPosition = FormStartPosition.Manual;
            prijava.Show();
        }
        /// <summary>
        /// Na događaj "Click"  zatvara glavni izbornik "Izbornik"
        /// </summary>
        /// <param name="sender">Referenca na gumb Button2</param>
        /// <param name="e">Dodatni podaci o događaju Click</param>
        /// 
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmIzbornik_Load(object sender, EventArgs e)
        {

        }
    }
}
