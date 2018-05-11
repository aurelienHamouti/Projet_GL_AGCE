namespace ProjetGL_AGCE
{
    partial class AffichageHistoriqueUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageHistoriqueUtilisateur));
            this.lblHistoriqueUtilisateurs = new System.Windows.Forms.Label();
            this.txtHistoriqueUtilisateur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHistoriqueUtilisateurs
            // 
            this.lblHistoriqueUtilisateurs.AutoSize = true;
            this.lblHistoriqueUtilisateurs.Location = new System.Drawing.Point(49, 56);
            this.lblHistoriqueUtilisateurs.Name = "lblHistoriqueUtilisateurs";
            this.lblHistoriqueUtilisateurs.Size = new System.Drawing.Size(302, 29);
            this.lblHistoriqueUtilisateurs.TabIndex = 0;
            this.lblHistoriqueUtilisateurs.Text = "Historique des utilisateurs :";
            // 
            // txtHistoriqueUtilisateur
            // 
            this.txtHistoriqueUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoriqueUtilisateur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHistoriqueUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistoriqueUtilisateur.Enabled = false;
            this.txtHistoriqueUtilisateur.Location = new System.Drawing.Point(54, 105);
            this.txtHistoriqueUtilisateur.Multiline = true;
            this.txtHistoriqueUtilisateur.Name = "txtHistoriqueUtilisateur";
            this.txtHistoriqueUtilisateur.ReadOnly = true;
            this.txtHistoriqueUtilisateur.Size = new System.Drawing.Size(577, 511);
            this.txtHistoriqueUtilisateur.TabIndex = 1;
            // 
            // AffichageHistoriqueUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 660);
            this.Controls.Add(this.txtHistoriqueUtilisateur);
            this.Controls.Add(this.lblHistoriqueUtilisateurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1200);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "AffichageHistoriqueUtilisateur";
            this.Text = " Affichage historique des utilisateurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoriqueUtilisateurs;
        private System.Windows.Forms.TextBox txtHistoriqueUtilisateur;
    }
}