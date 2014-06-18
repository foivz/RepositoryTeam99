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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            a = a.Replace("a", "b");
            textBox1.Text = a;

            textBox1.Select(textBox1.TextLength, 0);
        }
    }
}
