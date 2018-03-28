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
            this.lblParametres = new System.Windows.Forms.Button();
            this.btnTypeArticleMenagers = new System.Windows.Forms.Button();
            this.btnTypeArticlesSoins = new System.Windows.Forms.Button();
            this.btnListeDesVentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionCaissePrincipale
            // 
            this.btnConnectionCaissePrincipale.Location = new System.Drawing.Point(1855, 112);
            this.btnConnectionCaissePrincipale.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnConnectionCaissePrincipale.Name = "btnConnectionCaissePrincipale";
            this.btnConnectionCaissePrincipale.Size = new System.Drawing.Size(265, 80);
            this.btnConnectionCaissePrincipale.TabIndex = 0;
            this.btnConnectionCaissePrincipale.Text = "Changer de caissier";
            this.btnConnectionCaissePrincipale.UseVisualStyleBackColor = true;
            this.btnConnectionCaissePrincipale.Click += new System.EventHandler(this.btnConnectionCaissePrincipale_Click);
            // 
            // lblAccueilPrincipale
            // 
            this.lblAccueilPrincipale.AutoSize = true;
            this.lblAccueilPrincipale.Location = new System.Drawing.Point(44, 52);
            this.lblAccueilPrincipale.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAccueilPrincipale.Name = "lblAccueilPrincipale";
            this.lblAccueilPrincipale.Size = new System.Drawing.Size(586, 29);
            this.lblAccueilPrincipale.TabIndex = 2;
            this.lblAccueilPrincipale.Text = "AGCE - Application de gestion de caisse électronique";
            // 
            // lblCaissierPrincipale
            // 
            this.lblCaissierPrincipale.AutoSize = true;
            this.lblCaissierPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaissierPrincipale.Location = new System.Drawing.Point(1521, 51);
            this.lblCaissierPrincipale.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCaissierPrincipale.Name = "lblCaissierPrincipale";
            this.lblCaissierPrincipale.Size = new System.Drawing.Size(248, 29);
            this.lblCaissierPrincipale.TabIndex = 3;
            this.lblCaissierPrincipale.Text = "Caissier connecté :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1848, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aucun caissier connecté";
            // 
            // pnlCaissePrincipale
            // 
            this.pnlCaissePrincipale.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCaissePrincipale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlCaissePrincipale.Location = new System.Drawing.Point(1477, 27);
            this.pnlCaissePrincipale.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pnlCaissePrincipale.Name = "pnlCaissePrincipale";
            this.pnlCaissePrincipale.Size = new System.Drawing.Size(9, 1020);
            this.pnlCaissePrincipale.TabIndex = 5;
            // 
            // lblDescriptionPrixPrincipale
            // 
            this.lblDescriptionPrixPrincipale.AutoSize = true;
            this.lblDescriptionPrixPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPrixPrincipale.Location = new System.Drawing.Point(1521, 310);
            this.lblDescriptionPrixPrincipale.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescriptionPrixPrincipale.Name = "lblDescriptionPrixPrincipale";
            this.lblDescriptionPrixPrincipale.Size = new System.Drawing.Size(231, 48);
            this.lblDescriptionPrixPrincipale.TabIndex = 6;
            this.lblDescriptionPrixPrincipale.Text = "Prix total : ";
            // 
            // lblPrixPrincipale
            // 
            this.lblPrixPrincipale.AutoSize = true;
            this.lblPrixPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixPrincipale.Location = new System.Drawing.Point(1847, 310);
            this.lblPrixPrincipale.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPrixPrincipale.Name = "lblPrixPrincipale";
            this.lblPrixPrincipale.Size = new System.Drawing.Size(138, 48);
            this.lblPrixPrincipale.TabIndex = 7;
            this.lblPrixPrincipale.Text = "1000.-";
            this.lblPrixPrincipale.Click += new System.EventHandler(this.lblPrixPrincipale_Click);
            // 
            // btnImprimerQuittance
            // 
            this.btnImprimerQuittance.Location = new System.Drawing.Point(1526, 591);
            this.btnImprimerQuittance.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnImprimerQuittance.Name = "btnImprimerQuittance";
            this.btnImprimerQuittance.Size = new System.Drawing.Size(594, 120);
            this.btnImprimerQuittance.TabIndex = 8;
            this.btnImprimerQuittance.Text = "Imprimer quittance";
            this.btnImprimerQuittance.UseVisualStyleBackColor = true;
            this.btnImprimerQuittance.Click += new System.EventHandler(this.btnImprimerQuittance_Click);
            // 
            // btnTypeArticlesBoissons
            // 
            this.btnTypeArticlesBoissons.Location = new System.Drawing.Point(49, 212);
            this.btnTypeArticlesBoissons.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTypeArticlesBoissons.Name = "btnTypeArticlesBoissons";
            this.btnTypeArticlesBoissons.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticlesBoissons.TabIndex = 9;
            this.btnTypeArticlesBoissons.Text = "Boissons";
            this.btnTypeArticlesBoissons.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesSnack
            // 
            this.btnTypeArticlesSnack.Location = new System.Drawing.Point(401, 212);
            this.btnTypeArticlesSnack.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTypeArticlesSnack.Name = "btnTypeArticlesSnack";
            this.btnTypeArticlesSnack.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticlesSnack.TabIndex = 10;
            this.btnTypeArticlesSnack.Text = "Snack";
            this.btnTypeArticlesSnack.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesRepas
            // 
            this.btnTypeArticlesRepas.Location = new System.Drawing.Point(754, 212);
            this.btnTypeArticlesRepas.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTypeArticlesRepas.Name = "btnTypeArticlesRepas";
            this.btnTypeArticlesRepas.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticlesRepas.TabIndex = 11;
            this.btnTypeArticlesRepas.Text = "Repas";
            this.btnTypeArticlesRepas.UseVisualStyleBackColor = true;
            // 
            // btnTypeArticlesSandwichs
            // 
            this.btnTypeArticlesSandwichs.Location = new System.Drawing.Point(1099, 212);
            this.btnTypeArticlesSandwichs.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnTypeArticlesSandwichs.Name = "btnTypeArticlesSandwichs";
            this.btnTypeArticlesSandwichs.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticlesSandwichs.TabIndex = 12;
            this.btnTypeArticlesSandwichs.Text = "Sandwichs";
            this.btnTypeArticlesSandwichs.UseVisualStyleBackColor = true;
            // 
            // btnEncaissement
            // 
            this.btnEncaissement.Location = new System.Drawing.Point(1526, 430);
            this.btnEncaissement.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnEncaissement.Name = "btnEncaissement";
            this.btnEncaissement.Size = new System.Drawing.Size(594, 120);
            this.btnEncaissement.TabIndex = 13;
            this.btnEncaissement.Text = "Encaissement";
            this.btnEncaissement.UseVisualStyleBackColor = true;
            this.btnEncaissement.Click += new System.EventHandler(this.btnEncaissement_Click);
            // 
            // lblParametres
            // 
            this.lblParametres.Location = new System.Drawing.Point(1532, 912);
            this.lblParametres.Name = "lblParametres";
            this.lblParametres.Size = new System.Drawing.Size(591, 100);
            this.lblParametres.TabIndex = 14;
            this.lblParametres.Text = "paramètres";
            this.lblParametres.UseVisualStyleBackColor = true;
            this.lblParametres.Click += new System.EventHandler(this.lblParametres_Click);
            // 
            // btnTypeArticleMenagers
            // 
            this.btnTypeArticleMenagers.Location = new System.Drawing.Point(49, 566);
            this.btnTypeArticleMenagers.Margin = new System.Windows.Forms.Padding(7);
            this.btnTypeArticleMenagers.Name = "btnTypeArticleMenagers";
            this.btnTypeArticleMenagers.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticleMenagers.TabIndex = 15;
            this.btnTypeArticleMenagers.Text = "Produits ménagers & nettoyage";
            this.btnTypeArticleMenagers.UseVisualStyleBackColor = true;
            this.btnTypeArticleMenagers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTypeArticlesSoins
            // 
            this.btnTypeArticlesSoins.Location = new System.Drawing.Point(401, 566);
            this.btnTypeArticlesSoins.Margin = new System.Windows.Forms.Padding(7);
            this.btnTypeArticlesSoins.Name = "btnTypeArticlesSoins";
            this.btnTypeArticlesSoins.Size = new System.Drawing.Size(280, 268);
            this.btnTypeArticlesSoins.TabIndex = 16;
            this.btnTypeArticlesSoins.Text = "Soins & cosmétiques";
            this.btnTypeArticlesSoins.UseVisualStyleBackColor = true;
            // 
            // btnListeDesVentes
            // 
            this.btnListeDesVentes.Location = new System.Drawing.Point(1529, 753);
            this.btnListeDesVentes.Margin = new System.Windows.Forms.Padding(7);
            this.btnListeDesVentes.Name = "btnListeDesVentes";
            this.btnListeDesVentes.Size = new System.Drawing.Size(594, 120);
            this.btnListeDesVentes.TabIndex = 17;
            this.btnListeDesVentes.Text = "Liste des ventes";
            this.btnListeDesVentes.UseVisualStyleBackColor = true;
            this.btnListeDesVentes.Click += new System.EventHandler(this.btnListeDesVentes_Click);
            // 
            // frmCaissePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2167, 1070);
            this.Controls.Add(this.btnListeDesVentes);
            this.Controls.Add(this.btnTypeArticlesSoins);
            this.Controls.Add(this.btnTypeArticleMenagers);
            this.Controls.Add(this.lblParametres);
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
            this.Controls.Add(this.btnConnectionCaissePrincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmCaissePrincipale";
            this.Text = "frmCaissePrincipale";
            this.Load += new System.EventHandler(this.frmCaissePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionCaissePrincipale;
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
        private System.Windows.Forms.Button lblParametres;
        private System.Windows.Forms.Button btnTypeArticleMenagers;
        private System.Windows.Forms.Button btnTypeArticlesSoins;
        private System.Windows.Forms.Button btnListeDesVentes;
    }
}