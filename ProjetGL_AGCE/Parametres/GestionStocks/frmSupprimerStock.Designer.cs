namespace ProjetGL_AGCE
{
    partial class frmSupprimerStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupprimerStock));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimerArticle = new System.Windows.Forms.Button();
            this.lblArticleASupprimer = new System.Windows.Forms.Label();
            this.txtArticleASupprimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 152);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(79, 29);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerArticle
            // 
            this.btnSupprimerArticle.Location = new System.Drawing.Point(165, 152);
            this.btnSupprimerArticle.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSupprimerArticle.Name = "btnSupprimerArticle";
            this.btnSupprimerArticle.Size = new System.Drawing.Size(79, 29);
            this.btnSupprimerArticle.TabIndex = 2;
            this.btnSupprimerArticle.Text = "Supprimer";
            this.btnSupprimerArticle.UseVisualStyleBackColor = true;
            this.btnSupprimerArticle.Click += new System.EventHandler(this.btnSupprimerArticle_Click);
            // 
            // lblArticleASupprimer
            // 
            this.lblArticleASupprimer.AutoSize = true;
            this.lblArticleASupprimer.Location = new System.Drawing.Point(10, 27);
            this.lblArticleASupprimer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblArticleASupprimer.Name = "lblArticleASupprimer";
            this.lblArticleASupprimer.Size = new System.Drawing.Size(93, 13);
            this.lblArticleASupprimer.TabIndex = 0;
            this.lblArticleASupprimer.Text = "Article à supprimer";
            // 
            // txtArticleASupprimer
            // 
            this.txtArticleASupprimer.Location = new System.Drawing.Point(13, 57);
            this.txtArticleASupprimer.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtArticleASupprimer.Name = "txtArticleASupprimer";
            this.txtArticleASupprimer.Size = new System.Drawing.Size(138, 20);
            this.txtArticleASupprimer.TabIndex = 1;
            // 
            // frmSupprimerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(254, 196);
            this.ControlBox = false;
            this.Controls.Add(this.txtArticleASupprimer);
            this.Controls.Add(this.lblArticleASupprimer);
            this.Controls.Add(this.btnSupprimerArticle);
            this.Controls.Add(this.btnAnnuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmSupprimerStock";
            this.Text = " Supprimer un article du stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimerArticle;
        private System.Windows.Forms.Label lblArticleASupprimer;
        private System.Windows.Forms.TextBox txtArticleASupprimer;
    }
}