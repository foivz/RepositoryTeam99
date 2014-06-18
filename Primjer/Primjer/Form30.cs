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
    public partial class Form30 : Form
    {
        public Form30()
        {

            InitializeComponent();
            List<int> lista1 = new List<int>();
            for (int i = 1; i < 13; i++)
            {
                lista1.Add(i);

            }
            comboBox1.DataSource = lista1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            int a1 = int.Parse(a);
            DateTime d = new DateTime(2013, a1, 1);
            monthCalendar1.SetDate(d);
        }
    }
}
