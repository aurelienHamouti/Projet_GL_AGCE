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
            this.SuspendLayout();
            // 
            // btnConnectionCaissePrincipale
            // 
            this.btnConnectionCaissePrincipale.Location = new System.Drawing.Point(794, 367);
            this.btnConnectionCaissePrincipale.Name = "btnConnectionCaissePrincipale";
            this.btnConnectionCaissePrincipale.Size = new System.Drawing.Size(75, 23);
            this.btnConnectionCaissePrincipale.TabIndex = 0;
            this.btnConnectionCaissePrincipale.Text = "Connection";
            this.btnConnectionCaissePrincipale.UseVisualStyleBackColor = true;
            this.btnConnectionCaissePrincipale.Click += new System.EventHandler(this.btnConnectionCaissePrincipale_Click);
            // 
            // frmCaissePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 459);
            this.Controls.Add(this.btnConnectionCaissePrincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCaissePrincipale";
            this.Text = "frmCaissePrincipale";
            this.Load += new System.EventHandler(this.frmCaissePrincipale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionCaissePrincipale;
    }
}