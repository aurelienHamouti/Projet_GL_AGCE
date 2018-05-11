namespace ProjetGL_AGCE
{
    partial class frmModifierProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierProduit));
            this.lblModifierProduit = new System.Windows.Forms.Label();
            this.txtRechercherProduit = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifierProduit
            // 
            this.lblModifierProduit.AutoSize = true;
            this.lblModifierProduit.Location = new System.Drawing.Point(10, 21);
            this.lblModifierProduit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblModifierProduit.Name = "lblModifierProduit";
            this.lblModifierProduit.Size = new System.Drawing.Size(88, 13);
            this.lblModifierProduit.TabIndex = 0;
            this.lblModifierProduit.Text = "Produit à modifier";
            // 
            // txtRechercherProduit
            // 
            this.txtRechercherProduit.Location = new System.Drawing.Point(10, 48);
            this.txtRechercherProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtRechercherProduit.Name = "txtRechercherProduit";
            this.txtRechercherProduit.Size = new System.Drawing.Size(141, 20);
            this.txtRechercherProduit.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 113);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 34);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnModifierProduit
            // 
            this.btnModifierProduit.Location = new System.Drawing.Point(170, 113);
            this.btnModifierProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnModifierProduit.Name = "btnModifierProduit";
            this.btnModifierProduit.Size = new System.Drawing.Size(81, 34);
            this.btnModifierProduit.TabIndex = 2;
            this.btnModifierProduit.Text = "Modifier";
            this.btnModifierProduit.UseVisualStyleBackColor = true;
            this.btnModifierProduit.Click += new System.EventHandler(this.btnModifierProduit_Click);
            // 
            // frmModifierProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(261, 163);
            this.ControlBox = false;
            this.Controls.Add(this.btnModifierProduit);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtRechercherProduit);
            this.Controls.Add(this.lblModifierProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmModifierProduit";
            this.Text = " Modifier un produit";
            this.Load += new System.EventHandler(this.frmModifierProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifierProduit;
        private System.Windows.Forms.TextBox txtRechercherProduit;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierProduit;
    }
}