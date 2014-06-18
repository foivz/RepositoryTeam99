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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            int brojac = 0;
         int brojac1 = 0;
            foreach (var n in a)
            {
                if (char.IsNumber(n)) ;
                else brojac = brojac + 1;


            }
            foreach ( var m in b )
            {

                if (char.IsNumber(m));
                else brojac1 = brojac1+1;

            }
            if (brojac == 0 && brojac1 == 0)
            {
                int a1 = int.Parse(a);
                int b1 = int.Parse(b);

                if (b1 != 0)
                {
                    int c = a1 / b1;
                    MessageBox.Show("Rez dijeljenja: " + c);
                }
            }
                

            
           

        }
    }
}
