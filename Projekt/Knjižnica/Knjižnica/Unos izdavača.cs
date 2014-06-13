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
    public partial class FrmUnosIzdavaca : Form
    {
        public FrmUnosIzdavaca()
        {
            InitializeComponent();
        }

      

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste unesli izdavača");
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
