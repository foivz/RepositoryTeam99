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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_MouseMove(object sender, MouseEventArgs e)
        {
            int a = e.X;
            int b = e.Y;
            label1.Text = "a: " + a + " b: " + b;
        }
    }
}
