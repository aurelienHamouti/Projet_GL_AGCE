namespace ProjetGL_AGCE
{
    partial class frmAjouterUtilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterUtilisateur));
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.lblMotDePasseUtilisateur = new System.Windows.Forms.Label();
            this.lblRemarque = new System.Windows.Forms.Label();
            this.txtNomUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotDePasseUtilisateur = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(7, 25);
            this.lblNomUtilisateur.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(98, 13);
            this.lblNomUtilisateur.TabIndex = 0;
            this.lblNomUtilisateur.Text = "Nom de l\'utilisateur ";
            // 
            // lblMotDePasseUtilisateur
            // 
            this.lblMotDePasseUtilisateur.AutoSize = true;
            this.lblMotDePasseUtilisateur.Location = new System.Drawing.Point(7, 82);
            this.lblMotDePasseUtilisateur.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMotDePasseUtilisateur.Name = "lblMotDePasseUtilisateur";
            this.lblMotDePasseUtilisateur.Size = new System.Drawing.Size(140, 13);
            this.lblMotDePasseUtilisateur.TabIndex = 2;
            this.lblMotDePasseUtilisateur.Text = "Mot de passe de l\'utilisateur ";
            this.lblMotDePasseUtilisateur.Click += new System.EventHandler(this.lblMotDePasseUtilisateur_Click);
            // 
            // lblRemarque
            // 
            this.lblRemarque.AutoSize = true;
            this.lblRemarque.Location = new System.Drawing.Point(7, 147);
            this.lblRemarque.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRemarque.Name = "lblRemarque";
            this.lblRemarque.Size = new System.Drawing.Size(293, 13);
            this.lblRemarque.TabIndex = 6;
            this.lblRemarque.Text = "Remarque : Par défaut les nouveaux utilisateur sont caissiers";
            // 
            // txtNomUtilisateur
            // 
            this.txtNomUtilisateur.Location = new System.Drawing.Point(10, 50);
            this.txtNomUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtNomUtilisateur.Name = "txtNomUtilisateur";
            this.txtNomUtilisateur.Size = new System.Drawing.Size(132, 20);
            this.txtNomUtilisateur.TabIndex = 1;
            // 
            // txtMotDePasseUtilisateur
            // 
            this.txtMotDePasseUtilisateur.Location = new System.Drawing.Point(10, 107);
            this.txtMotDePasseUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtMotDePasseUtilisateur.Name = "txtMotDePasseUtilisateur";
            this.txtMotDePasseUtilisateur.Size = new System.Drawing.Size(132, 20);
            this.txtMotDePasseUtilisateur.TabIndex = 3;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(225, 182);
            this.btnConfirmer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(82, 28);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 182);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(82, 28);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(317, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtMotDePasseUtilisateur);
            this.Controls.Add(this.txtNomUtilisateur);
            this.Controls.Add(this.lblRemarque);
            this.Controls.Add(this.lblMotDePasseUtilisateur);
            this.Controls.Add(this.lblNomUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmAjouterUtilisateur";
            this.Text = " Ajouter un utilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.Label lblMotDePasseUtilisateur;
        private System.Windows.Forms.Label lblRemarque;
        private System.Windows.Forms.TextBox txtNomUtilisateur;
        private System.Windows.Forms.TextBox txtMotDePasseUtilisateur;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
    }
}