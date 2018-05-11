namespace ProjetGL_AGCE
{
    partial class frmListeVentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListeVentes));
            this.lblDerniresVentes = new System.Windows.Forms.Label();
            this.txtDernieresVentes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDerniresVentes
            // 
            this.lblDerniresVentes.AutoSize = true;
            this.lblDerniresVentes.Location = new System.Drawing.Point(15, 20);
            this.lblDerniresVentes.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDerniresVentes.Name = "lblDerniresVentes";
            this.lblDerniresVentes.Size = new System.Drawing.Size(111, 13);
            this.lblDerniresVentes.TabIndex = 0;
            this.lblDerniresVentes.Text = "Les dernières ventes :";
            // 
            // txtDernieresVentes
            // 
            this.txtDernieresVentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDernieresVentes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDernieresVentes.Enabled = false;
            this.txtDernieresVentes.Location = new System.Drawing.Point(18, 48);
            this.txtDernieresVentes.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtDernieresVentes.Multiline = true;
            this.txtDernieresVentes.Name = "txtDernieresVentes";
            this.txtDernieresVentes.Size = new System.Drawing.Size(266, 259);
            this.txtDernieresVentes.TabIndex = 1;
            // 
            // frmListeVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 323);
            this.Controls.Add(this.txtDernieresVentes);
            this.Controls.Add(this.lblDerniresVentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximumSize = new System.Drawing.Size(695, 559);
            this.MinimumSize = new System.Drawing.Size(266, 335);
            this.Name = "frmListeVentes";
            this.Text = " Liste des ventes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDerniresVentes;
        private System.Windows.Forms.TextBox txtDernieresVentes;
    }
}