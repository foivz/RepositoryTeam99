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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            timer1.Start();
        }
        static int brojac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = DateTime.Now.Year;
            int b = DateTime.Now.Month;
            int c = DateTime.Now.Day;
            DateTime d = new DateTime(a, b, c);
            while (d.DayOfWeek != DayOfWeek.Friday)
            {
                brojac = brojac + 1;
                d = d.AddDays(1);

            }
            timer1.Stop();
            MessageBox.Show("Broj dana: " + brojac);
        }
    }
}
