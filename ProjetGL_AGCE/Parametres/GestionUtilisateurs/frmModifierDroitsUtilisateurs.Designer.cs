namespace ProjetGL_AGCE
{
    partial class frmModifierDroitsUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierDroitsUtilisateurs));
            this.lblSelectionnerUtilisateur = new System.Windows.Forms.Label();
            this.txtSelectionnerUtilisateur = new System.Windows.Forms.TextBox();
            this.grpDroitsUtilisateur = new System.Windows.Forms.GroupBox();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.rdoAdministrateur = new System.Windows.Forms.RadioButton();
            this.rdoCaissier = new System.Windows.Forms.RadioButton();
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpDroitsUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectionnerUtilisateur
            // 
            this.lblSelectionnerUtilisateur.AutoSize = true;
            this.lblSelectionnerUtilisateur.Location = new System.Drawing.Point(7, 21);
            this.lblSelectionnerUtilisateur.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSelectionnerUtilisateur.Name = "lblSelectionnerUtilisateur";
            this.lblSelectionnerUtilisateur.Size = new System.Drawing.Size(128, 13);
            this.lblSelectionnerUtilisateur.TabIndex = 0;
            this.lblSelectionnerUtilisateur.Text = "Sélectionner un utilisateur";
            this.lblSelectionnerUtilisateur.Click += new System.EventHandler(this.lblSelectionnerUtilisateur_Click);
            // 
            // txtSelectionnerUtilisateur
            // 
            this.txtSelectionnerUtilisateur.Location = new System.Drawing.Point(10, 51);
            this.txtSelectionnerUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtSelectionnerUtilisateur.Name = "txtSelectionnerUtilisateur";
            this.txtSelectionnerUtilisateur.Size = new System.Drawing.Size(124, 20);
            this.txtSelectionnerUtilisateur.TabIndex = 1;
            // 
            // grpDroitsUtilisateur
            // 
            this.grpDroitsUtilisateur.Controls.Add(this.rdoAdmin);
            this.grpDroitsUtilisateur.Controls.Add(this.rdoAdministrateur);
            this.grpDroitsUtilisateur.Controls.Add(this.rdoCaissier);
            this.grpDroitsUtilisateur.Location = new System.Drawing.Point(164, 21);
            this.grpDroitsUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grpDroitsUtilisateur.Name = "grpDroitsUtilisateur";
            this.grpDroitsUtilisateur.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.grpDroitsUtilisateur.Size = new System.Drawing.Size(118, 126);
            this.grpDroitsUtilisateur.TabIndex = 2;
            this.grpDroitsUtilisateur.TabStop = false;
            this.grpDroitsUtilisateur.Text = "Droits";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(12, 91);
            this.rdoAdmin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(91, 17);
            this.rdoAdmin.TabIndex = 2;
            this.rdoAdmin.TabStop = true;
            this.rdoAdmin.Text = "Administrateur";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoAdministrateur
            // 
            this.rdoAdministrateur.AutoSize = true;
            this.rdoAdministrateur.Location = new System.Drawing.Point(12, 61);
            this.rdoAdministrateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoAdministrateur.Name = "rdoAdministrateur";
            this.rdoAdministrateur.Size = new System.Drawing.Size(84, 17);
            this.rdoAdministrateur.TabIndex = 1;
            this.rdoAdministrateur.TabStop = true;
            this.rdoAdministrateur.Text = "Gestionnaire";
            this.rdoAdministrateur.UseVisualStyleBackColor = true;
            // 
            // rdoCaissier
            // 
            this.rdoCaissier.AutoSize = true;
            this.rdoCaissier.Location = new System.Drawing.Point(12, 30);
            this.rdoCaissier.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rdoCaissier.Name = "rdoCaissier";
            this.rdoCaissier.Size = new System.Drawing.Size(61, 17);
            this.rdoCaissier.TabIndex = 0;
            this.rdoCaissier.TabStop = true;
            this.rdoCaissier.Text = "Caissier";
            this.rdoCaissier.UseVisualStyleBackColor = true;
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Location = new System.Drawing.Point(186, 183);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(96, 36);
            this.btnConfirmation.TabIndex = 3;
            this.btnConfirmation.Text = "Confirmer";
            this.btnConfirmation.UseVisualStyleBackColor = true;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 183);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 36);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmModifierDroitsUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(293, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.grpDroitsUtilisateur);
            this.Controls.Add(this.txtSelectionnerUtilisateur);
            this.Controls.Add(this.lblSelectionnerUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmModifierDroitsUtilisateurs";
            this.Text = " Modifier droits utilisateurs";
            this.grpDroitsUtilisateur.ResumeLayout(false);
            this.grpDroitsUtilisateur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionnerUtilisateur;
        private System.Windows.Forms.TextBox txtSelectionnerUtilisateur;
        private System.Windows.Forms.GroupBox grpDroitsUtilisateur;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.RadioButton rdoAdministrateur;
        private System.Windows.Forms.RadioButton rdoCaissier;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Button btnAnnuler;
    }
}