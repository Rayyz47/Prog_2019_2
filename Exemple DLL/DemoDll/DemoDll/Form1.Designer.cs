namespace DemoDll
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb4 = new System.Windows.Forms.TextBox();
            this.txtNb3 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNb1
            // 
            this.txtNb1.Location = new System.Drawing.Point(33, 128);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(100, 20);
            this.txtNb1.TabIndex = 0;
            // 
            // txtNb4
            // 
            this.txtNb4.Location = new System.Drawing.Point(33, 243);
            this.txtNb4.Name = "txtNb4";
            this.txtNb4.Size = new System.Drawing.Size(100, 20);
            this.txtNb4.TabIndex = 1;
            // 
            // txtNb3
            // 
            this.txtNb3.Location = new System.Drawing.Point(33, 204);
            this.txtNb3.Name = "txtNb3";
            this.txtNb3.Size = new System.Drawing.Size(100, 20);
            this.txtNb3.TabIndex = 2;
            // 
            // txtNb2
            // 
            this.txtNb2.Location = new System.Drawing.Point(33, 166);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(100, 20);
            this.txtNb2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 135);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(33, 281);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(181, 20);
            this.txtResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNb2);
            this.Controls.Add(this.txtNb3);
            this.Controls.Add(this.txtNb4);
            this.Controls.Add(this.txtNb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb4;
        private System.Windows.Forms.TextBox txtNb3;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

