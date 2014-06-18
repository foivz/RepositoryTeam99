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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        static int brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            int a1 = a.Length;
            int b1 = b.Length;
           
            foreach (var v in a)
            {
                if (char.IsLetter(v) && char.IsUpper(v))
                    brojac = brojac + 1;

            }
            if (!a.Contains("#")) MessageBox.Show("Lozinka ne sadrzi #");
            if (brojac < 3) MessageBox.Show("Premalo velikih slova");
            if (a1 < 5 || b1 < 5) MessageBox.Show("Lozinke prekratke");
            if (a != b) MessageBox.Show("Krive lozinke");
        }
    }
}
