namespace ProjetGL_AGCE
{
    partial class frmSupprimerProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupprimerProduit));
            this.lblRechercheProduit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimerProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRechercheProduit
            // 
            this.lblRechercheProduit.AutoSize = true;
            this.lblRechercheProduit.Location = new System.Drawing.Point(7, 24);
            this.lblRechercheProduit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRechercheProduit.Name = "lblRechercheProduit";
            this.lblRechercheProduit.Size = new System.Drawing.Size(155, 13);
            this.lblRechercheProduit.TabIndex = 0;
            this.lblRechercheProduit.Text = "Rechercher produit à supprimer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 121);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(79, 32);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerProduit
            // 
            this.btnSupprimerProduit.Location = new System.Drawing.Point(172, 121);
            this.btnSupprimerProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimerProduit.Name = "btnSupprimerProduit";
            this.btnSupprimerProduit.Size = new System.Drawing.Size(79, 32);
            this.btnSupprimerProduit.TabIndex = 2;
            this.btnSupprimerProduit.Text = "Supprimer";
            this.btnSupprimerProduit.UseVisualStyleBackColor = true;
            this.btnSupprimerProduit.Click += new System.EventHandler(this.btnSupprimerProduit_Click);
            // 
            // frmSupprimerProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(261, 163);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimerProduit);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRechercheProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmSupprimerProduit";
            this.Text = " Supprimer un produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRechercheProduit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimerProduit;
    }
}