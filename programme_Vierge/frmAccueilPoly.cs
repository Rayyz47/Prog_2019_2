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
    public partial class frmAccueilPoly : Form
    {
        string name = "";
        string content = "";
        string dateToDisplay = "";
        public frmAccueilPoly()
        {
            InitializeComponent();
        }

        private void btnInfoPoly_Click(object sender, EventArgs e)
        {
            cPolymorphismInfos poly = new cPolymorphismInfos();
            poly.isAuthor();
            name = poly.nameChild;
            this.txtAuthor.Text = name;

            poly.isContent();
            content = poly.contentChild;
            txtContent.Text = content;

            poly.isDate();
            dateToDisplay = poly.dateEntryChild.ToString();
            txtDate.Text = dateToDisplay;

            string txtboxTitle = txtTitle.Text;

            if (poly.IsTitle(txtboxTitle))
            {
                MessageBox.Show(txtboxTitle);
                this.BackColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Veuillez entrer des lettres uniquement!");
                this.BackColor = Color.GreenYellow;
            }
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            cInterface interFace = new cInterface();
            interFace.isAuthor();
            name = interFace.nameChild;
            txtAuthor.Text = name;

            interFace.isContent();
            content = interFace.contentChild;
            txtContent.Text = content;

            interFace.isDate();
            dateToDisplay = interFace.dateEntryChild.ToString();
            txtDate.Text = dateToDisplay;
        }

        private void btnInfoDll_Click(object sender, EventArgs e)
        {
            cDllInfos dllinfos = new cDllInfos();
            dllinfos.isAuthor();
            name = dllinfos.nameChild;
            txtAuthor.Text = name;

            dllinfos.isContent();
            content = dllinfos.contentChild;
            txtContent.Text = content;

            dllinfos.isDate();
            dateToDisplay = dllinfos.dateEntryChild.ToString();
            txtDate.Text = dateToDisplay;
        }

        private void btnInfoGitGithub_Click(object sender, EventArgs e)
        {
            cGit git = new cGit();
            git.isAuthor();
            name = git.nameChild;
            txtAuthor.Text = name;

            git.isContent();
            content = git.contentChild;
            txtContent.Text = content;

            git.isDate();
            dateToDisplay = git.dateEntryChild.ToString();
            txtDate.Text = dateToDisplay;

            string txtboxTitle = txtTitle.Text;

            if (git.IsTitle(txtboxTitle))
            {
                MessageBox.Show(txtboxTitle);
                this.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("Veuillez entrer des lettres uniquement!");
                this.BackColor = Color.Fuchsia;
            }
        }
    }
}
