using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programme_Vierge
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnToPoly_Click(object sender, EventArgs e)
        {
            frmAccueilPoly poly = new frmAccueilPoly();
            poly.Show();
        }
    }
}
