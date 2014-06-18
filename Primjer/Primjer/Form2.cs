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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        static int brojac = 0;
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            brojac = brojac + 1;
            
            
            try
            {
                a = int.Parse(textBox1.Text);
                if (brojac > a)
                {
                    brojac = 0;
                    this.button1.Text = brojac.ToString();
                }
            
            }
            catch
            {
                
            }
      
             this.button1.Text = brojac.ToString();
            
            
        }
    }
}
