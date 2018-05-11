namespace ProjetGL_AGCE
{
    partial class frmGestionHistorique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionHistorique));
            this.btnAfficherHistorique = new System.Windows.Forms.Button();
            this.btnAfficherVentes = new System.Windows.Forms.Button();
            this.btnAfficherStocks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfficherHistorique
            // 
            this.btnAfficherHistorique.Location = new System.Drawing.Point(20, 18);
            this.btnAfficherHistorique.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAfficherHistorique.Name = "btnAfficherHistorique";
            this.btnAfficherHistorique.Size = new System.Drawing.Size(101, 79);
            this.btnAfficherHistorique.TabIndex = 0;
            this.btnAfficherHistorique.Text = "Afficher historique utilisateurs";
            this.btnAfficherHistorique.UseVisualStyleBackColor = true;
            this.btnAfficherHistorique.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAfficherVentes
            // 
            this.btnAfficherVentes.Location = new System.Drawing.Point(149, 18);
            this.btnAfficherVentes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAfficherVentes.Name = "btnAfficherVentes";
            this.btnAfficherVentes.Size = new System.Drawing.Size(101, 79);
            this.btnAfficherVentes.TabIndex = 1;
            this.btnAfficherVentes.Text = "Afficher historique ventes";
            this.btnAfficherVentes.UseVisualStyleBackColor = true;
            this.btnAfficherVentes.Click += new System.EventHandler(this.btnAfficherVentes_Click);
            // 
            // btnAfficherStocks
            // 
            this.btnAfficherStocks.Location = new System.Drawing.Point(278, 18);
            this.btnAfficherStocks.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAfficherStocks.Name = "btnAfficherStocks";
            this.btnAfficherStocks.Size = new System.Drawing.Size(101, 79);
            this.btnAfficherStocks.TabIndex = 2;
            this.btnAfficherStocks.Text = "Afficher historique stocks";
            this.btnAfficherStocks.UseVisualStyleBackColor = true;
            this.btnAfficherStocks.Click += new System.EventHandler(this.btnAfficherStocks_Click);
            // 
            // frmGestionHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 121);
            this.Controls.Add(this.btnAfficherStocks);
            this.Controls.Add(this.btnAfficherVentes);
            this.Controls.Add(this.btnAfficherHistorique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmGestionHistorique";
            this.Text = " Gestion des historiques";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherHistorique;
        private System.Windows.Forms.Button btnAfficherVentes;
        private System.Windows.Forms.Button btnAfficherStocks;
    }
}