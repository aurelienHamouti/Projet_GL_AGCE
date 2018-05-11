namespace ProjetGL_AGCE
{
    partial class frmAjouterStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterStock));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouterStock = new System.Windows.Forms.Button();
            this.lblArticleAjouterStock = new System.Windows.Forms.Label();
            this.txtAjouterStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 129);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(91, 33);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnAjouterStock
            // 
            this.btnAjouterStock.Location = new System.Drawing.Point(163, 129);
            this.btnAjouterStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterStock.Name = "btnAjouterStock";
            this.btnAjouterStock.Size = new System.Drawing.Size(91, 33);
            this.btnAjouterStock.TabIndex = 2;
            this.btnAjouterStock.Text = "Ajouter";
            this.btnAjouterStock.UseVisualStyleBackColor = true;
            this.btnAjouterStock.Click += new System.EventHandler(this.btnAjouterStock_Click);
            // 
            // lblArticleAjouterStock
            // 
            this.lblArticleAjouterStock.AutoSize = true;
            this.lblArticleAjouterStock.Location = new System.Drawing.Point(10, 23);
            this.lblArticleAjouterStock.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblArticleAjouterStock.Name = "lblArticleAjouterStock";
            this.lblArticleAjouterStock.Size = new System.Drawing.Size(124, 13);
            this.lblArticleAjouterStock.TabIndex = 0;
            this.lblArticleAjouterStock.Text = "Article à ajouter au stock";
            // 
            // txtAjouterStock
            // 
            this.txtAjouterStock.Location = new System.Drawing.Point(10, 51);
            this.txtAjouterStock.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtAjouterStock.Name = "txtAjouterStock";
            this.txtAjouterStock.Size = new System.Drawing.Size(135, 20);
            this.txtAjouterStock.TabIndex = 1;
            // 
            // frmAjouterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(264, 176);
            this.ControlBox = false;
            this.Controls.Add(this.txtAjouterStock);
            this.Controls.Add(this.lblArticleAjouterStock);
            this.Controls.Add(this.btnAjouterStock);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmAjouterStock";
            this.Text = " Ajouter stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouterStock;
        private System.Windows.Forms.Label lblArticleAjouterStock;
        private System.Windows.Forms.TextBox txtAjouterStock;
    }
}