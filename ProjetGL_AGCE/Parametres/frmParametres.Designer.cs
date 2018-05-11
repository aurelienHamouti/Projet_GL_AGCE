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
            this.btnGestionUtilisateurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUtilisateurs.Location = new System.Drawing.Point(18, 30);
            this.btnGestionUtilisateurs.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGestionUtilisateurs.Name = "btnGestionUtilisateurs";
            this.btnGestionUtilisateurs.Size = new System.Drawing.Size(129, 112);
            this.btnGestionUtilisateurs.TabIndex = 0;
            this.btnGestionUtilisateurs.Text = "Gestion des utilisateurs";
            this.btnGestionUtilisateurs.UseVisualStyleBackColor = true;
            this.btnGestionUtilisateurs.Click += new System.EventHandler(this.btnGestionUtilisateurs_Click);
            // 
            // btnGestionProduit
            // 
            this.btnGestionProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProduit.Location = new System.Drawing.Point(168, 30);
            this.btnGestionProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGestionProduit.Name = "btnGestionProduit";
            this.btnGestionProduit.Size = new System.Drawing.Size(129, 112);
            this.btnGestionProduit.TabIndex = 1;
            this.btnGestionProduit.Text = "Gestion des produits";
            this.btnGestionProduit.UseVisualStyleBackColor = true;
            this.btnGestionProduit.Click += new System.EventHandler(this.btnGestionProduit_Click);
            // 
            // btnGestionDesStocks
            // 
            this.btnGestionDesStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionDesStocks.Location = new System.Drawing.Point(18, 159);
            this.btnGestionDesStocks.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGestionDesStocks.Name = "btnGestionDesStocks";
            this.btnGestionDesStocks.Size = new System.Drawing.Size(129, 112);
            this.btnGestionDesStocks.TabIndex = 2;
            this.btnGestionDesStocks.Text = "Gestion des stocks";
            this.btnGestionDesStocks.UseVisualStyleBackColor = true;
            this.btnGestionDesStocks.Click += new System.EventHandler(this.btnGestionDesStocks_Click);
            // 
            // btnParametresImpression
            // 
            this.btnParametresImpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametresImpression.Location = new System.Drawing.Point(168, 159);
            this.btnParametresImpression.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnParametresImpression.Name = "btnParametresImpression";
            this.btnParametresImpression.Size = new System.Drawing.Size(129, 112);
            this.btnParametresImpression.TabIndex = 3;
            this.btnParametresImpression.Text = "Paramètres d\'impression";
            this.btnParametresImpression.UseVisualStyleBackColor = true;
            this.btnParametresImpression.Click += new System.EventHandler(this.btnParametresImpression_Click);
            // 
            // btnGestionHistoriques
            // 
            this.btnGestionHistoriques.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionHistoriques.Location = new System.Drawing.Point(316, 30);
            this.btnGestionHistoriques.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnGestionHistoriques.Name = "btnGestionHistoriques";
            this.btnGestionHistoriques.Size = new System.Drawing.Size(99, 240);
            this.btnGestionHistoriques.TabIndex = 4;
            this.btnGestionHistoriques.Text = "Gestion des historiques";
            this.btnGestionHistoriques.UseVisualStyleBackColor = true;
            this.btnGestionHistoriques.Click += new System.EventHandler(this.btnGestionHistoriques_Click);
            // 
            // frmParametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 298);
            this.Controls.Add(this.btnGestionHistoriques);
            this.Controls.Add(this.btnParametresImpression);
            this.Controls.Add(this.btnGestionDesStocks);
            this.Controls.Add(this.btnGestionProduit);
            this.Controls.Add(this.btnGestionUtilisateurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmParametres";
            this.Text = " Paramètres de l\'application";
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