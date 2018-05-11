namespace ProjetGL_AGCE
{
    partial class frmGestionImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionImpression));
            this.btnChoixImprimante = new System.Windows.Forms.Button();
            this.btnImprimerParametres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoixImprimante
            // 
            this.btnChoixImprimante.Location = new System.Drawing.Point(22, 22);
            this.btnChoixImprimante.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnChoixImprimante.Name = "btnChoixImprimante";
            this.btnChoixImprimante.Size = new System.Drawing.Size(110, 93);
            this.btnChoixImprimante.TabIndex = 0;
            this.btnChoixImprimante.Text = "Choisir une imprimante";
            this.btnChoixImprimante.UseVisualStyleBackColor = true;
            this.btnChoixImprimante.Click += new System.EventHandler(this.btnChoixImprimante_Click);
            // 
            // btnImprimerParametres
            // 
            this.btnImprimerParametres.Location = new System.Drawing.Point(161, 22);
            this.btnImprimerParametres.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnImprimerParametres.Name = "btnImprimerParametres";
            this.btnImprimerParametres.Size = new System.Drawing.Size(110, 93);
            this.btnImprimerParametres.TabIndex = 1;
            this.btnImprimerParametres.Text = "Imprimer paramètres d\'impression";
            this.btnImprimerParametres.UseVisualStyleBackColor = true;
            this.btnImprimerParametres.Click += new System.EventHandler(this.btnImprimerParametres_Click);
            // 
            // frmGestionImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 136);
            this.Controls.Add(this.btnImprimerParametres);
            this.Controls.Add(this.btnChoixImprimante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmGestionImpression";
            this.Text = " Paramètres d\'impression";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoixImprimante;
        private System.Windows.Forms.Button btnImprimerParametres;
    }
}