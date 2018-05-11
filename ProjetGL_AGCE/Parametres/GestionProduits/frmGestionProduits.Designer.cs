namespace ProjetGL_AGCE
{
    partial class frmGestionProduits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProduits));
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.btnSuppressionProduit = new System.Windows.Forms.Button();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Location = new System.Drawing.Point(21, 21);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(86, 67);
            this.btnAjouterProduit.TabIndex = 0;
            this.btnAjouterProduit.Text = "Ajouter un produit";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuppressionProduit
            // 
            this.btnSuppressionProduit.Location = new System.Drawing.Point(128, 21);
            this.btnSuppressionProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSuppressionProduit.Name = "btnSuppressionProduit";
            this.btnSuppressionProduit.Size = new System.Drawing.Size(86, 67);
            this.btnSuppressionProduit.TabIndex = 1;
            this.btnSuppressionProduit.Text = "Supprimer produit";
            this.btnSuppressionProduit.UseVisualStyleBackColor = true;
            this.btnSuppressionProduit.Click += new System.EventHandler(this.btnSuppressionProduit_Click);
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(235, 21);
            this.btnSupprimerProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(86, 67);
            this.btnSupprimerProduit.TabIndex = 2;
            this.btnSupprimerProduit.Text = "Modifier produit";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // frmGestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 112);
            this.Controls.Add(this.btnSupprimerProduit);
            this.Controls.Add(this.btnSuppressionProduit);
            this.Controls.Add(this.btnAjouterProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmGestionProduits";
            this.Text = " Gestion des produits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.Button btnSuppressionProduit;
        private System.Windows.Forms.Button btnSupprimerProduit;
    }
}