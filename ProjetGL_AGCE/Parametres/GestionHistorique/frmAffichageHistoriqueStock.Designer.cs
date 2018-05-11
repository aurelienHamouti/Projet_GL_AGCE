namespace ProjetGL_AGCE
{
    partial class frmAffichageHistoriqueStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAffichageHistoriqueStock));
            this.lblAffichageStock = new System.Windows.Forms.Label();
            this.txtAffichageStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAffichageStock
            // 
            this.lblAffichageStock.AutoSize = true;
            this.lblAffichageStock.Location = new System.Drawing.Point(37, 46);
            this.lblAffichageStock.Name = "lblAffichageStock";
            this.lblAffichageStock.Size = new System.Drawing.Size(230, 29);
            this.lblAffichageStock.TabIndex = 0;
            this.lblAffichageStock.Text = "Historique du stock :";
            // 
            // txtAffichageStock
            // 
            this.txtAffichageStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAffichageStock.Location = new System.Drawing.Point(42, 105);
            this.txtAffichageStock.Multiline = true;
            this.txtAffichageStock.Name = "txtAffichageStock";
            this.txtAffichageStock.Size = new System.Drawing.Size(478, 526);
            this.txtAffichageStock.TabIndex = 1;
            // 
            // frmAffichageHistoriqueStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 671);
            this.Controls.Add(this.txtAffichageStock);
            this.Controls.Add(this.lblAffichageStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 1200);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "frmAffichageHistoriqueStock";
            this.Text = " Affichage historique du Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffichageStock;
        private System.Windows.Forms.TextBox txtAffichageStock;
    }
}