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
            this.lblCaissierConnecte = new System.Windows.Forms.Label();
            this.pnlCaissePrincipale = new System.Windows.Forms.Panel();
            this.lblDescriptionPrixPrincipale = new System.Windows.Forms.Label();
            this.lblPrixPrincipale = new System.Windows.Forms.Label();
            this.btnImprimerQuittance = new System.Windows.Forms.Button();
            this.btnTypeArticlesBoissons = new System.Windows.Forms.Button();
            this.btnTypeArticlesSnack = new System.Windows.Forms.Button();
            this.btnTypeArticlesRepas = new System.Windows.Forms.Button();
            this.btnTypeArticlesSandwichs = new System.Windows.Forms.Button();
            this.btnEncaissement = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.btnTypeArticleMenagers = new System.Windows.Forms.Button();
            this.btnTypeArticlesSoins = new System.Windows.Forms.Button();
            this.btnListeDesVentes = new System.Windows.Forms.Button();
            this.btnTypeArticlePetiteFourniture = new System.Windows.Forms.Button();
            this.btnQuitterApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionCaissePrincipale
            // 
            this.btnConnectionCaissePrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionCaissePrincipale.Location = new System.Drawing.Point(794, 48);
            this.btnConnectionCaissePrincipale.Name = "btnConnectionCaissePrincipale";
            this.btnConnectionCaissePrincipale.Size = new System.Drawing.Size(121, 37);
            this.btnConnectionCaissePrincipale.TabIndex = 0;
            this.btnConnectionCaissePrincipale.Text = "Changer de caissier";
            this.btnConnectionCaissePrincipale.UseVisualStyleBackColor = true;
            this.btnConnectionCaissePrincipale.Click += new System.EventHandler(this.btnConnectionCaissePrincipale_Click);
            // 
            // lblAccueilPrincipale
            // 
            this.lblAccueilPrincipale.AutoSize = true;
            this.lblAccueilPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilPrincipale.Location = new System.Drawing.Point(17, 23);
            this.lblAccueilPrincipale.Name = "lblAccueilPrincipale";
            this.lblAccueilPrincipale.Size = new System.Drawing.Size(438, 20);
            this.lblAccueilPrincipale.TabIndex = 13;
            this.lblAccueilPrincipale.Text = "AGCE - Application de gestion de caisse électronique";
            // 
            // lblCaissierPrincipale
            // 
            this.lblCaissierPrincipale.AutoSize = true;
            this.lblCaissierPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaissierPrincipale.Location = new System.Drawing.Point(652, 23);
            this.lblCaissierPrincipale.Name = "lblCaissierPrincipale";
            this.lblCaissierPrincipale.Size = new System.Drawing.Size(116, 13);
            this.lblCaissierPrincipale.TabIndex = 16;
            this.lblCaissierPrincipale.Text = "Caissier connecté :";
            // 
            // lblCaissierConnecte
            // 
            this.lblCaissierConnecte.AutoSize = true;
            this.lblCaissierConnecte.Location = new System.Drawing.Point(791, 23);
            this.lblCaissierConnecte.Name = "lblCaissierConnecte";
            this.lblCaissierConnecte.Size = new System.Drawing.Size(124, 13);
            this.lblCaissierConnecte.TabIndex = 17;
            this.lblCaissierConnecte.Text = "Aucun caissier connecté";
            // 
            // pnlCaissePrincipale
            // 
            this.pnlCaissePrincipale.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCaissePrincipale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlCaissePrincipale.Location = new System.Drawing.Point(618, 12);
            this.pnlCaissePrincipale.Name = "pnlCaissePrincipale";
            this.pnlCaissePrincipale.Size = new System.Drawing.Size(10, 554);
            this.pnlCaissePrincipale.TabIndex = 18;
            // 
            // lblDescriptionPrixPrincipale
            // 
            this.lblDescriptionPrixPrincipale.AutoSize = true;
            this.lblDescriptionPrixPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionPrixPrincipale.Location = new System.Drawing.Point(655, 133);
            this.lblDescriptionPrixPrincipale.Name = "lblDescriptionPrixPrincipale";
            this.lblDescriptionPrixPrincipale.Size = new System.Drawing.Size(128, 26);
            this.lblDescriptionPrixPrincipale.TabIndex = 14;
            this.lblDescriptionPrixPrincipale.Text = "Prix total : ";
            // 
            // lblPrixPrincipale
            // 
            this.lblPrixPrincipale.AutoSize = true;
            this.lblPrixPrincipale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixPrincipale.Location = new System.Drawing.Point(789, 133);
            this.lblPrixPrincipale.Name = "lblPrixPrincipale";
            this.lblPrixPrincipale.Size = new System.Drawing.Size(40, 26);
            this.lblPrixPrincipale.TabIndex = 15;
            this.lblPrixPrincipale.Text = "0.-";
            // 
            // btnImprimerQuittance
            // 
            this.btnImprimerQuittance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerQuittance.Location = new System.Drawing.Point(665, 270);
            this.btnImprimerQuittance.Name = "btnImprimerQuittance";
            this.btnImprimerQuittance.Size = new System.Drawing.Size(250, 50);
            this.btnImprimerQuittance.TabIndex = 2;
            this.btnImprimerQuittance.Text = "Imprimer quittance";
            this.btnImprimerQuittance.UseVisualStyleBackColor = true;
            this.btnImprimerQuittance.Click += new System.EventHandler(this.btnImprimerQuittance_Click);
            // 
            // btnTypeArticlesBoissons
            // 
            this.btnTypeArticlesBoissons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlesBoissons.Location = new System.Drawing.Point(21, 95);
            this.btnTypeArticlesBoissons.Name = "btnTypeArticlesBoissons";
            this.btnTypeArticlesBoissons.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesBoissons.TabIndex = 6;
            this.btnTypeArticlesBoissons.Text = "Boissons";
            this.btnTypeArticlesBoissons.UseVisualStyleBackColor = true;
            this.btnTypeArticlesBoissons.Click += new System.EventHandler(this.btnTypeArticlesBoissons_Click);
            // 
            // btnTypeArticlesSnack
            // 
            this.btnTypeArticlesSnack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlesSnack.Location = new System.Drawing.Point(171, 95);
            this.btnTypeArticlesSnack.Name = "btnTypeArticlesSnack";
            this.btnTypeArticlesSnack.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesSnack.TabIndex = 7;
            this.btnTypeArticlesSnack.Text = "Snack";
            this.btnTypeArticlesSnack.UseVisualStyleBackColor = true;
            this.btnTypeArticlesSnack.Click += new System.EventHandler(this.btnTypeArticlesSnack_Click);
            // 
            // btnTypeArticlesRepas
            // 
            this.btnTypeArticlesRepas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlesRepas.Location = new System.Drawing.Point(321, 95);
            this.btnTypeArticlesRepas.Name = "btnTypeArticlesRepas";
            this.btnTypeArticlesRepas.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesRepas.TabIndex = 8;
            this.btnTypeArticlesRepas.Text = "Repas";
            this.btnTypeArticlesRepas.UseVisualStyleBackColor = true;
            this.btnTypeArticlesRepas.Click += new System.EventHandler(this.btnTypeArticlesRepas_Click);
            // 
            // btnTypeArticlesSandwichs
            // 
            this.btnTypeArticlesSandwichs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlesSandwichs.Location = new System.Drawing.Point(471, 95);
            this.btnTypeArticlesSandwichs.Name = "btnTypeArticlesSandwichs";
            this.btnTypeArticlesSandwichs.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesSandwichs.TabIndex = 9;
            this.btnTypeArticlesSandwichs.Text = "Sandwichs";
            this.btnTypeArticlesSandwichs.UseVisualStyleBackColor = true;
            this.btnTypeArticlesSandwichs.Click += new System.EventHandler(this.btnTypeArticlesSandwichs_Click);
            // 
            // btnEncaissement
            // 
            this.btnEncaissement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncaissement.Location = new System.Drawing.Point(665, 201);
            this.btnEncaissement.Name = "btnEncaissement";
            this.btnEncaissement.Size = new System.Drawing.Size(250, 50);
            this.btnEncaissement.TabIndex = 1;
            this.btnEncaissement.Text = "Encaissement";
            this.btnEncaissement.UseVisualStyleBackColor = true;
            this.btnEncaissement.Click += new System.EventHandler(this.btnEncaissement_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametres.Location = new System.Drawing.Point(665, 408);
            this.btnParametres.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(250, 50);
            this.btnParametres.TabIndex = 4;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = true;
            this.btnParametres.Click += new System.EventHandler(this.btnParametres_Click);
            // 
            // btnTypeArticleMenagers
            // 
            this.btnTypeArticleMenagers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticleMenagers.Location = new System.Drawing.Point(21, 254);
            this.btnTypeArticleMenagers.Name = "btnTypeArticleMenagers";
            this.btnTypeArticleMenagers.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticleMenagers.TabIndex = 10;
            this.btnTypeArticleMenagers.Text = "Produits ménagers ";
            this.btnTypeArticleMenagers.UseVisualStyleBackColor = true;
            this.btnTypeArticleMenagers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTypeArticlesSoins
            // 
            this.btnTypeArticlesSoins.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlesSoins.Location = new System.Drawing.Point(172, 254);
            this.btnTypeArticlesSoins.Name = "btnTypeArticlesSoins";
            this.btnTypeArticlesSoins.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlesSoins.TabIndex = 11;
            this.btnTypeArticlesSoins.Text = "Soins et cosmétiques";
            this.btnTypeArticlesSoins.UseVisualStyleBackColor = true;
            this.btnTypeArticlesSoins.Click += new System.EventHandler(this.btnTypeArticlesSoins_Click);
            // 
            // btnListeDesVentes
            // 
            this.btnListeDesVentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeDesVentes.Location = new System.Drawing.Point(665, 339);
            this.btnListeDesVentes.Name = "btnListeDesVentes";
            this.btnListeDesVentes.Size = new System.Drawing.Size(250, 50);
            this.btnListeDesVentes.TabIndex = 3;
            this.btnListeDesVentes.Text = "Liste des ventes";
            this.btnListeDesVentes.UseVisualStyleBackColor = true;
            this.btnListeDesVentes.Click += new System.EventHandler(this.btnListeDesVentes_Click);
            // 
            // btnTypeArticlePetiteFourniture
            // 
            this.btnTypeArticlePetiteFourniture.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeArticlePetiteFourniture.Location = new System.Drawing.Point(323, 254);
            this.btnTypeArticlePetiteFourniture.Name = "btnTypeArticlePetiteFourniture";
            this.btnTypeArticlePetiteFourniture.Size = new System.Drawing.Size(120, 120);
            this.btnTypeArticlePetiteFourniture.TabIndex = 12;
            this.btnTypeArticlePetiteFourniture.Text = "Petite fourniture";
            this.btnTypeArticlePetiteFourniture.UseVisualStyleBackColor = true;
            this.btnTypeArticlePetiteFourniture.Click += new System.EventHandler(this.btnTypeArticlePetiteFourniture_Click);
            // 
            // btnQuitterApplication
            // 
            this.btnQuitterApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterApplication.Location = new System.Drawing.Point(665, 477);
            this.btnQuitterApplication.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnQuitterApplication.Name = "btnQuitterApplication";
            this.btnQuitterApplication.Size = new System.Drawing.Size(250, 50);
            this.btnQuitterApplication.TabIndex = 5;
            this.btnQuitterApplication.Text = "Quitter application";
            this.btnQuitterApplication.UseVisualStyleBackColor = true;
            this.btnQuitterApplication.Click += new System.EventHandler(this.btnQuitterApplication_Click);
            // 
            // frmCaissePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 578);
            this.Controls.Add(this.btnQuitterApplication);
            this.Controls.Add(this.btnTypeArticlePetiteFourniture);
            this.Controls.Add(this.btnListeDesVentes);
            this.Controls.Add(this.btnTypeArticlesSoins);
            this.Controls.Add(this.btnTypeArticleMenagers);
            this.Controls.Add(this.btnParametres);
            this.Controls.Add(this.btnEncaissement);
            this.Controls.Add(this.btnTypeArticlesSandwichs);
            this.Controls.Add(this.btnTypeArticlesRepas);
            this.Controls.Add(this.btnTypeArticlesSnack);
            this.Controls.Add(this.btnTypeArticlesBoissons);
            this.Controls.Add(this.btnImprimerQuittance);
            this.Controls.Add(this.lblPrixPrincipale);
            this.Controls.Add(this.lblDescriptionPrixPrincipale);
            this.Controls.Add(this.pnlCaissePrincipale);
            this.Controls.Add(this.lblCaissierConnecte);
            this.Controls.Add(this.lblCaissierPrincipale);
            this.Controls.Add(this.lblAccueilPrincipale);
            this.Controls.Add(this.btnConnectionCaissePrincipale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaissePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Caisse principale";
            this.Load += new System.EventHandler(this.frmCaissePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionCaissePrincipale;
        private System.Windows.Forms.Label lblAccueilPrincipale;
        private System.Windows.Forms.Label lblCaissierPrincipale;
        private System.Windows.Forms.Label lblCaissierConnecte;
        private System.Windows.Forms.Panel pnlCaissePrincipale;
        private System.Windows.Forms.Label lblDescriptionPrixPrincipale;
        private System.Windows.Forms.Label lblPrixPrincipale;
        private System.Windows.Forms.Button btnImprimerQuittance;
        private System.Windows.Forms.Button btnTypeArticlesBoissons;
        private System.Windows.Forms.Button btnTypeArticlesSnack;
        private System.Windows.Forms.Button btnTypeArticlesRepas;
        private System.Windows.Forms.Button btnTypeArticlesSandwichs;
        private System.Windows.Forms.Button btnEncaissement;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Button btnTypeArticleMenagers;
        private System.Windows.Forms.Button btnTypeArticlesSoins;
        private System.Windows.Forms.Button btnListeDesVentes;
        private System.Windows.Forms.Button btnTypeArticlePetiteFourniture;
        private System.Windows.Forms.Button btnQuitterApplication;
    }
}