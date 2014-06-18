using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            brojac = brojac + 1;
            Form1 f = new Form1();
            f.button1.Text = brojac.ToString();
            f.Show();

        }
    }
}
