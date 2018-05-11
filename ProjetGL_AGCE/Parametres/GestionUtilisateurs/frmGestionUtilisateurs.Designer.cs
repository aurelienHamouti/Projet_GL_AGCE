namespace ProjetGL_AGCE
{
    partial class frmGestionUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionUtilisateurs));
            this.btnAjouterUtilisateur = new System.Windows.Forms.Button();
            this.btnSupprimerUtilisateur = new System.Windows.Forms.Button();
            this.btnModifierUtilisateur = new System.Windows.Forms.Button();
            this.btnDroitsUtilisateurs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterUtilisateur
            // 
            this.btnAjouterUtilisateur.Location = new System.Drawing.Point(18, 20);
            this.btnAjouterUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterUtilisateur.Name = "btnAjouterUtilisateur";
            this.btnAjouterUtilisateur.Size = new System.Drawing.Size(98, 80);
            this.btnAjouterUtilisateur.TabIndex = 0;
            this.btnAjouterUtilisateur.Text = "Ajouter un utilisateur";
            this.btnAjouterUtilisateur.UseVisualStyleBackColor = true;
            this.btnAjouterUtilisateur.Click += new System.EventHandler(this.btnAjouterUtilisateur_Click);
            // 
            // btnSupprimerUtilisateur
            // 
            this.btnSupprimerUtilisateur.Location = new System.Drawing.Point(144, 20);
            this.btnSupprimerUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimerUtilisateur.Name = "btnSupprimerUtilisateur";
            this.btnSupprimerUtilisateur.Size = new System.Drawing.Size(98, 80);
            this.btnSupprimerUtilisateur.TabIndex = 1;
            this.btnSupprimerUtilisateur.Text = "Supprimer un utilsateur";
            this.btnSupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.btnSupprimerUtilisateur.Click += new System.EventHandler(this.btnSupprimerUtilisateur_Click);
            // 
            // btnModifierUtilisateur
            // 
            this.btnModifierUtilisateur.Location = new System.Drawing.Point(270, 20);
            this.btnModifierUtilisateur.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnModifierUtilisateur.Name = "btnModifierUtilisateur";
            this.btnModifierUtilisateur.Size = new System.Drawing.Size(98, 80);
            this.btnModifierUtilisateur.TabIndex = 2;
            this.btnModifierUtilisateur.Text = "Modifier un utilisateur";
            this.btnModifierUtilisateur.UseVisualStyleBackColor = true;
            this.btnModifierUtilisateur.Click += new System.EventHandler(this.btnModifierUtilisateur_Click);
            // 
            // btnDroitsUtilisateurs
            // 
            this.btnDroitsUtilisateurs.Location = new System.Drawing.Point(396, 20);
            this.btnDroitsUtilisateurs.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnDroitsUtilisateurs.Name = "btnDroitsUtilisateurs";
            this.btnDroitsUtilisateurs.Size = new System.Drawing.Size(98, 80);
            this.btnDroitsUtilisateurs.TabIndex = 3;
            this.btnDroitsUtilisateurs.Text = "Gestion des droits des utilisateurs";
            this.btnDroitsUtilisateurs.UseVisualStyleBackColor = true;
            this.btnDroitsUtilisateurs.Click += new System.EventHandler(this.btnDroitsUtilisateurs_Click);
            // 
            // frmGestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 121);
            this.Controls.Add(this.btnDroitsUtilisateurs);
            this.Controls.Add(this.btnModifierUtilisateur);
            this.Controls.Add(this.btnSupprimerUtilisateur);
            this.Controls.Add(this.btnAjouterUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmGestionUtilisateurs";
            this.Text = " Gestion des utilisateurs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterUtilisateur;
        private System.Windows.Forms.Button btnSupprimerUtilisateur;
        private System.Windows.Forms.Button btnModifierUtilisateur;
        private System.Windows.Forms.Button btnDroitsUtilisateurs;
    }
}