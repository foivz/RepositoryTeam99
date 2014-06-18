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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
