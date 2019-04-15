namespace programme_Vierge
{
    partial class frmAccueilPoly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInfoGitGithub = new System.Windows.Forms.Button();
            this.btnInfoDll = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnInfoPoly = new System.Windows.Forms.Button();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInfoGitGithub
            // 
            this.btnInfoGitGithub.Location = new System.Drawing.Point(778, 278);
            this.btnInfoGitGithub.Name = "btnInfoGitGithub";
            this.btnInfoGitGithub.Size = new System.Drawing.Size(116, 47);
            this.btnInfoGitGithub.TabIndex = 23;
            this.btnInfoGitGithub.Text = "Infos Git/GitHub";
            this.btnInfoGitGithub.UseVisualStyleBackColor = true;
            this.btnInfoGitGithub.Click += new System.EventHandler(this.btnInfoGitGithub_Click);
            // 
            // btnInfoDll
            // 
            this.btnInfoDll.Location = new System.Drawing.Point(778, 225);
            this.btnInfoDll.Name = "btnInfoDll";
            this.btnInfoDll.Size = new System.Drawing.Size(116, 47);
            this.btnInfoDll.TabIndex = 22;
            this.btnInfoDll.Text = "Infos DLL";
            this.btnInfoDll.UseVisualStyleBackColor = true;
            this.btnInfoDll.Click += new System.EventHandler(this.btnInfoDll_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(527, 443);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(111, 13);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Auteur de l\'information";
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(778, 172);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(116, 47);
            this.btnInterface.TabIndex = 20;
            this.btnInterface.Text = "Infos Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnInfoPoly
            // 
            this.btnInfoPoly.Location = new System.Drawing.Point(778, 119);
            this.btnInfoPoly.Name = "btnInfoPoly";
            this.btnInfoPoly.Size = new System.Drawing.Size(116, 47);
            this.btnInfoPoly.TabIndex = 19;
            this.btnInfoPoly.Text = "Infos Polymorphisme";
            this.btnInfoPoly.UseVisualStyleBackColor = true;
            this.btnInfoPoly.Click += new System.EventHandler(this.btnInfoPoly_Click);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(9, 100);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(47, 13);
            this.lblContent.TabIndex = 18;
            this.lblContent.Text = "Contenu";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(313, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 26);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Titre : Validation d\'entrée sur des boutons \"Surprises!\"\r\n(@\"^(?=.*\\d)(?=.*[a-z])" +
    "(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$\")";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(316, 66);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(294, 20);
            this.txtDate.TabIndex = 15;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(530, 468);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(237, 20);
            this.txtAuthor.TabIndex = 14;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(9, 119);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(758, 306);
            this.txtContent.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(10, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(294, 20);
            this.txtTitle.TabIndex = 12;
            // 
            // frmAccueilPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 516);
            this.Controls.Add(this.btnInfoGitGithub);
            this.Controls.Add(this.btnInfoDll);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.btnInfoPoly);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAccueilPoly";
            this.Text = "frmAccueilPoly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfoGitGithub;
        private System.Windows.Forms.Button btnInfoDll;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnInfoPoly;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
    }
}