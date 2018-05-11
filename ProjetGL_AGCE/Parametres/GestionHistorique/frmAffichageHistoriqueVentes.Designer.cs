namespace ProjetGL_AGCE
{
    partial class frmAffichageHistoriqueVentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffichageHistoriqueVentes));
            this.lblAffichageVentes = new System.Windows.Forms.Label();
            this.txtAffichageVentes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAffichageVentes
            // 
            this.lblAffichageVentes.AutoSize = true;
            this.lblAffichageVentes.Location = new System.Drawing.Point(45, 45);
            this.lblAffichageVentes.Name = "lblAffichageVentes";
            this.lblAffichageVentes.Size = new System.Drawing.Size(257, 29);
            this.lblAffichageVentes.TabIndex = 0;
            this.lblAffichageVentes.Text = "Historique des ventes :";
            // 
            // txtAffichageVentes
            // 
            this.txtAffichageVentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAffichageVentes.Location = new System.Drawing.Point(50, 102);
            this.txtAffichageVentes.Multiline = true;
            this.txtAffichageVentes.Name = "txtAffichageVentes";
            this.txtAffichageVentes.Size = new System.Drawing.Size(463, 519);
            this.txtAffichageVentes.TabIndex = 1;
            // 
            // frmAffichageHistoriqueVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 674);
            this.Controls.Add(this.txtAffichageVentes);
            this.Controls.Add(this.lblAffichageVentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1200);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "frmAffichageHistoriqueVentes";
            this.Text = " Affichage historique des ventes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffichageVentes;
        private System.Windows.Forms.TextBox txtAffichageVentes;
    }
}