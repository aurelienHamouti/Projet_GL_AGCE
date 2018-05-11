namespace ProjetGL_AGCE
{
    partial class frmGestionStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionStocks));
            this.btnAjouterArticles = new System.Windows.Forms.Button();
            this.btnEnleverArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouterArticles
            // 
            this.btnAjouterArticles.Location = new System.Drawing.Point(21, 26);
            this.btnAjouterArticles.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterArticles.Name = "btnAjouterArticles";
            this.btnAjouterArticles.Size = new System.Drawing.Size(133, 83);
            this.btnAjouterArticles.TabIndex = 0;
            this.btnAjouterArticles.Text = "Ajouter des articles au stock";
            this.btnAjouterArticles.UseVisualStyleBackColor = true;
            this.btnAjouterArticles.Click += new System.EventHandler(this.btnAjouterArticles_Click);
            // 
            // btnEnleverArticle
            // 
            this.btnEnleverArticle.Location = new System.Drawing.Point(187, 26);
            this.btnEnleverArticle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEnleverArticle.Name = "btnEnleverArticle";
            this.btnEnleverArticle.Size = new System.Drawing.Size(133, 83);
            this.btnEnleverArticle.TabIndex = 1;
            this.btnEnleverArticle.Text = "Enlever un article du stock";
            this.btnEnleverArticle.UseVisualStyleBackColor = true;
            this.btnEnleverArticle.Click += new System.EventHandler(this.btnEnleverArticle_Click);
            // 
            // frmGestionStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 137);
            this.Controls.Add(this.btnEnleverArticle);
            this.Controls.Add(this.btnAjouterArticles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmGestionStocks";
            this.Text = " Gestion des stocks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterArticles;
        private System.Windows.Forms.Button btnEnleverArticle;
    }
}