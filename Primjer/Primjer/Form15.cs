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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static int brojac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int a1 = int.Parse(a);

            int iduca = a1 + 1;
            DateTime d = new DateTime(a1,1,1);
            while (d.Year != iduca)
            {

                if (d.Day == 13 && (d.DayOfWeek == DayOfWeek.Friday))
                    brojac = brojac + 1;


                d= d.AddDays(1);

            }
            MessageBox.Show("Broj: " + brojac);
        }
    }
}
