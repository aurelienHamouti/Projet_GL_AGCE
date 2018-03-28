namespace ProjetGL_AGCE
{
    partial class frmParametres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametres));
            this.btnGestionUtilisateurs = new System.Windows.Forms.Button();
            this.btnGestionProduit = new System.Windows.Forms.Button();
            this.btnGestionDesStocks = new System.Windows.Forms.Button();
            this.btnParametresImpression = new System.Windows.Forms.Button();
            this.btnGestionHistoriques = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionUtilisateurs
            // 
            this.btnGestionUtilisateurs.Location = new System.Drawing.Point(41, 68);
            this.btnGestionUtilisateurs.Name = "btnGestionUtilisateurs";
            this.btnGestionUtilisateurs.Size = new System.Drawing.Size(300, 250);
            this.btnGestionUtilisateurs.TabIndex = 0;
            this.btnGestionUtilisateurs.Text = "Gestion des utilisateurs";
            this.btnGestionUtilisateurs.UseVisualStyleBackColor = true;
            // 
            // btnGestionProduit
            // 
            this.btnGestionProduit.Location = new System.Drawing.Point(392, 68);
            this.btnGestionProduit.Name = "btnGestionProduit";
            this.btnGestionProduit.Size = new System.Drawing.Size(300, 250);
            this.btnGestionProduit.TabIndex = 1;
            this.btnGestionProduit.Text = "Gestion des produits";
            this.btnGestionProduit.UseVisualStyleBackColor = true;
            // 
            // btnGestionDesStocks
            // 
            this.btnGestionDesStocks.Location = new System.Drawing.Point(41, 354);
            this.btnGestionDesStocks.Name = "btnGestionDesStocks";
            this.btnGestionDesStocks.Size = new System.Drawing.Size(300, 250);
            this.btnGestionDesStocks.TabIndex = 2;
            this.btnGestionDesStocks.Text = "Gestion des stocks";
            this.btnGestionDesStocks.UseVisualStyleBackColor = true;
            // 
            // btnParametresImpression
            // 
            this.btnParametresImpression.Location = new System.Drawing.Point(392, 354);
            this.btnParametresImpression.Name = "btnParametresImpression";
            this.btnParametresImpression.Size = new System.Drawing.Size(300, 250);
            this.btnParametresImpression.TabIndex = 3;
            this.btnParametresImpression.Text = "Paramètres d\'impression";
            this.btnParametresImpression.UseVisualStyleBackColor = true;
            // 
            // btnGestionHistoriques
            // 
            this.btnGestionHistoriques.Location = new System.Drawing.Point(728, 68);
            this.btnGestionHistoriques.Name = "btnGestionHistoriques";
            this.btnGestionHistoriques.Size = new System.Drawing.Size(300, 250);
            this.btnGestionHistoriques.TabIndex = 4;
            this.btnGestionHistoriques.Text = "Gestion des historiques";
            this.btnGestionHistoriques.UseVisualStyleBackColor = true;
            // 
            // frmParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.btnGestionHistoriques);
            this.Controls.Add(this.btnParametresImpression);
            this.Controls.Add(this.btnGestionDesStocks);
            this.Controls.Add(this.btnGestionProduit);
            this.Controls.Add(this.btnGestionUtilisateurs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParametres";
            this.Text = "Écran des paramètres";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionUtilisateurs;
        private System.Windows.Forms.Button btnGestionProduit;
        private System.Windows.Forms.Button btnGestionDesStocks;
        private System.Windows.Forms.Button btnParametresImpression;
        private System.Windows.Forms.Button btnGestionHistoriques;
    }
}