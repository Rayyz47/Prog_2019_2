using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL_VB;
using Dll_cSharpe;


namespace DemoDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DLL dllCSharpe = new DLL();
            Class1 dllVB = new Class1();
            decimal nb1 = dllCSharpe.validationNumber(txtNb1.Text);
            decimal nb2 = dllCSharpe.validationNumber(txtNb2.Text);
            decimal nb3 = dllCSharpe.validationNumber(txtNb3.Text);
            decimal nb4 = dllCSharpe.validationNumber(txtNb4.Text);
            nb1 = dllVB.add(nb1, nb2);
            nb3 = dllVB.add(nb3, nb4);
            txtResult.Text = dllVB.add(nb1, nb3).ToString();
            clean();
        }
        private void clean()
        {
            txtNb1.Text = "";
            txtNb2.Text = "";
            txtNb3.Text = "";
            txtNb4.Text = "";
        }
    }
}
