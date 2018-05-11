namespace ProjetGL_AGCE
{
    partial class frmSupprimerUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupprimerUtilisateur));
            this.lblSelectionnerUtilisateur = new System.Windows.Forms.Label();
            this.txtSelectionnerUtilisateur = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectionnerUtilisateur
            // 
            this.lblSelectionnerUtilisateur.AutoSize = true;
            this.lblSelectionnerUtilisateur.Location = new System.Drawing.Point(7, 22);
            this.lblSelectionnerUtilisateur.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSelectionnerUtilisateur.Name = "lblSelectionnerUtilisateur";
            this.lblSelectionnerUtilisateur.Size = new System.Drawing.Size(128, 13);
            this.lblSelectionnerUtilisateur.TabIndex = 0;
            this.lblSelectionnerUtilisateur.Text = "Sélectionner un utilisateur";
            // 
            // txtSelectionnerUtilisateur
            // 
            this.txtSelectionnerUtilisateur.Location = new System.Drawing.Point(10, 45);
            this.txtSelectionnerUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtSelectionnerUtilisateur.Name = "txtSelectionnerUtilisateur";
            this.txtSelectionnerUtilisateur.Size = new System.Drawing.Size(128, 20);
            this.txtSelectionnerUtilisateur.TabIndex = 1;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(170, 136);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 32);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 136);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(83, 32);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmSupprimerUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(263, 178);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtSelectionnerUtilisateur);
            this.Controls.Add(this.lblSelectionnerUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmSupprimerUtilisateur";
            this.Text = " Supprimer un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionnerUtilisateur;
        private System.Windows.Forms.TextBox txtSelectionnerUtilisateur;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}