namespace ProjetGL_AGCE
{
    partial class frmCaissePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaissePrincipale));
            this.btnConnectionCaissePrincipale = new System.Windows.Forms.Button();
            this.btnArticle1 = new System.Windows.Forms.Button();
            this.lblAccueilPrincipale = new System.Windows.Forms.Label();
            this.lblCaissierPrincipale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlCaissePrincipale = new System.Windows.Forms.Panel();
            this.lblDescriptionPrixPrincipale = new System.Windows.Forms.Label();
            this.lblPrixPrincipale = new System.Windows.Forms.Label();
            this.btnImprimerQuittance = new System.Windows.Forms.Button();
            this.btnTypeArticlesBoissons = new System.Windows.Forms.Button();
            this.btnTypeArticlesSnack = new System.Windows.Forms.Button();
            this.btnTypeArticlesRepas = new System.Windows.Forms.Button();
            this.btnTypeArticlesSandwichs = new System.Windows.Forms.Button();
            this.btnEncaissement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionCaissePrincipale
            // 
            this.btnConnectionCaissePrincipale.Location = new System.Drawing.Point(795, 50);
            this.btnConnectionCaissePrincipale.Name = "btnConnectionCaissePrincipale";
            this.btnConnectionCaissePrincipale.Size = new System.Drawing.Size(121, 23);
            this.btnConnectionCaissePrincipale.TabIndex = 0;
            this.btnConnectionCaissePrincipale.Text = "Changer de caissier";
            this.btnConnectionCaissePrincipale.UseVisualStyleBackColor = true;
            this.btnConnectionCaissePrincipale.Click += new System.EventHandler(this.btnConnectionCaissePrincipale_Click);
            // 
            // btnArticle1
            // 
            this.btnArticle1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticle1.Image = ((System.Drawing.Image)(resources.GetObject("btnArticle1.Image")));
            this.btnArticle1.Location = new System.Drawing.Point(21, 272);
            this.btnArticle1.Name = "btnArticle1";
            this.btnArticle1.Size = new System.Drawing.Size(120, 120);
            this.btnArticle1.TabIndex = 1;
            this.btnArticle1.Text = "test";
            this.btnArticle1.UseVisualStyleBackColor = true;
            // 
            // lblAccueilPrincipale
            // 
            this.lblAccueilPrincipale.AutoSize = true;
            this.lblAccueilPrincipale.Location = new System.Drawing.Point(34, 23);
            this.lblAccueilPrincipale.Name = "lblAccueilPrincipale";
            this.lblAccueilPrincipale.Size = new System.Drawing.Size(258, 13);
            this.lblAccueilPrincipale.TabIndex = 2;
            this.lblAccueilPrincipale.Text = "AGCE - Application de gestion de caisse électronique";
            // 
            // lblCaissierPrincipale
            // 
            this.lblCaissierPrincipale.AutoSize = true;
            this.lblCaissierPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaissierPrincipale.Location = new System.Drawing.Point(652, 23);
            this.lblCaissierPrincipale.Name = "lblCaissierPrincipale";
            this.lblCaissierPrincipale.Size = new System.Drawing.Size(116, 13);
            this.lblCaissierPrincipale.TabIndex = 3;
            this.lblCaissierPrincipale.Text = "Caissier connecté :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aucun caissier connecté";
            // 
            // pnlCaissePrincipale
            // 
            this.pnlCaissePrincipale.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCaissePrincipale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlCaissePrincipale.Location = new System.Drawing.Point(633, 12);
            this.pnlCaissePrincipale.Name = "pnlCaissePrincipale";
            this.pnlCaissePrincipale.Size = new System.Drawing.Size(4, 435);
            this.pnlCaissePrincipale.TabIndex = 5;
            // 
            // lblDescriptionPrixPrincipale
            // 
            this.lblDescriptionPrixPrincipale.AutoSize = true;
            this.lblDescriptionPrixPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPrixPrincipale.Location = new System.Drawing.Point(652, 139);
            this.lblDescriptionPrixPrincipale.Name = "lblDescriptionPrixPrincipale";
            this.lblDescriptionPrixPrincipale.Size = new System.Drawing.Size(69, 13);
            this.lblDescriptionPrixPrincipale.TabIndex = 6;
            this.lblDescriptionPrixPrincipale.Text = "Prix total : ";
            // 
            // lblPrixPrincipale
            // 
            this.lblPrixPrincipale.AutoSize = true;
            this.lblPrixPrincipale.Location = new System.Drawing.Point(731, 139);
            this.lblPrixPrincipale.Name = "lblPrixPrincipale";
            this.lblPrixPrincipale.Size = new System.Drawing.Size(37, 13);
            this.lblPrixPrincipale.TabIndex = 7;
            this.lblPrixPrincipale.Text = "1000.-";
            // 
            // btnImprimerQuittance
            // 
            this.btnImprimerQuittance.Location = new System.Drawing.Point(753, 424);
            this.btnImprimerQuittance.Name = "btnImprimerQuittance";
            this.btnImprimerQuittance.Size = new System.Drawing.Size(163, 23);
            this.btnImprimerQuittance.TabIndex = 8;
            this.btnImprimerQuittance.Text = "Imprimer quittance";
            this.btnImprimerQuittance.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesBoissons
            // 
            this.btnTypeArticlesBoissons.Location = new System.Drawing.Point(21, 95);
            this.btnTypeArticlesBoissons.Name = "btnTypeArticlesBoissons";
            this.btnTypeArticlesBoissons.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesBoissons.TabIndex = 9;
            this.btnTypeArticlesBoissons.Text = "Boissons";
            this.btnTypeArticlesBoissons.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesSnack
            // 
            this.btnTypeArticlesSnack.Location = new System.Drawing.Point(172, 95);
            this.btnTypeArticlesSnack.Name = "btnTypeArticlesSnack";
            this.btnTypeArticlesSnack.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesSnack.TabIndex = 10;
            this.btnTypeArticlesSnack.Text = "Snack";
            this.btnTypeArticlesSnack.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesRepas
            // 
            this.btnTypeArticlesRepas.Location = new System.Drawing.Point(323, 95);
            this.btnTypeArticlesRepas.Name = "btnTypeArticlesRepas";
            this.btnTypeArticlesRepas.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesRepas.TabIndex = 11;
            this.btnTypeArticlesRepas.Text = "Repas";
            this.btnTypeArticlesRepas.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesSandwichs
            // 
            this.btnTypeArticlesSandwichs.Location = new System.Drawing.Point(471, 95);
            this.btnTypeArticlesSandwichs.Name = "btnTypeArticlesSandwichs";
            this.btnTypeArticlesSandwichs.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesSandwichs.TabIndex = 12;
            this.btnTypeArticlesSandwichs.Text = "Sandwichs";
            this.btnTypeArticlesSandwichs.UseVisualStyleBackColor = true;
            // 
            // btnEncaissement
            // 
            this.btnEncaissement.Location = new System.Drawing.Point(753, 369);
            this.btnEncaissement.Name = "btnEncaissement";
            this.btnEncaissement.Size = new System.Drawing.Size(163, 23);
            this.btnEncaissement.TabIndex = 13;
            this.btnEncaissement.Text = "Encaissement";
            this.btnEncaissement.UseVisualStyleBackColor = true;
            // 
            // frmCaissePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 459);
            this.Controls.Add(this.btnEncaissement);
            this.Controls.Add(this.btnTypeArticlesSandwichs);
            this.Controls.Add(this.btnTypeArticlesRepas);
            this.Controls.Add(this.btnTypeArticlesSnack);
            this.Controls.Add(this.btnTypeArticlesBoissons);
            this.Controls.Add(this.btnImprimerQuittance);
            this.Controls.Add(this.lblPrixPrincipale);
            this.Controls.Add(this.lblDescriptionPrixPrincipale);
            this.Controls.Add(this.pnlCaissePrincipale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCaissierPrincipale);
            this.Controls.Add(this.lblAccueilPrincipale);
            this.Controls.Add(this.btnArticle1);
            this.Controls.Add(this.btnConnectionCaissePrincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaissePrincipale";
            this.Text = "frmCaissePrincipale";
            this.Load += new System.EventHandler(this.frmCaissePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionCaissePrincipale;
        private System.Windows.Forms.Button btnArticle1;
        private System.Windows.Forms.Label lblAccueilPrincipale;
        private System.Windows.Forms.Label lblCaissierPrincipale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCaissePrincipale;
        private System.Windows.Forms.Label lblDescriptionPrixPrincipale;
        private System.Windows.Forms.Label lblPrixPrincipale;
        private System.Windows.Forms.Button btnImprimerQuittance;
        private System.Windows.Forms.Button btnTypeArticlesBoissons;
        private System.Windows.Forms.Button btnTypeArticlesSnack;
        private System.Windows.Forms.Button btnTypeArticlesRepas;
        private System.Windows.Forms.Button btnTypeArticlesSandwichs;
        private System.Windows.Forms.Button btnEncaissement;
    }
}