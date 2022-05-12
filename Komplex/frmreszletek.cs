using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplex
{
    public partial class frmreszletek : Form
    {
        public frmreszletek()
        {
            InitializeComponent();
        }

        private void frmreszletek_Load(object sender, EventArgs e)
        {
            label_nev.Text = "Almási Miklós";
            lB_foglalkozas.Items.Clear();
            //lB_foglalkozas.Items.Add();
        }
    }
}
