using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica
{
    public partial class FrmKnjigaPoAutoru : Form
    {
        public FrmKnjigaPoAutoru()
        {
            InitializeComponent();
        }
        
       

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
