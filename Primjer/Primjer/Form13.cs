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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();

            String[] a1 = a.Split(',');

            foreach ( var o in a1 )
            {
                int m = int.Parse(o);
                lista1.Add(m);   

            }
            lista1.Sort();
            String z = "";
            foreach (var q in lista1)
            {

                z += q.ToString() + ",";

            }
            textBox2.Text = z;
        }
    }
}
