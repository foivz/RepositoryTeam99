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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }
        double secs = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            WindowState = FormWindowState.Maximized;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secs -= 1;

            double secss = Math.Ceiling(secs);
            button1.Text = secss.ToString();

            if (secs <= 0)
            {
                //timer1.in
                timer1.Stop();
                this.Close();
            }

        }
       
    }
}