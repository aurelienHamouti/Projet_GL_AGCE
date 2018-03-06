namespace ProjetGL_AGCE
{
    partial class frCaissePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCaissePrincipale));
            this.btnArticle_1 = new System.Windows.Forms.Button();
            this.lbl_caissier = new System.Windows.Forms.Label();
            this.lbl_nom_caissier = new System.Windows.Forms.Label();
            this.btnArticle_2 = new System.Windows.Forms.Button();
            this.btnArticle_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArticle_1
            // 
            this.btnArticle_1.Image = ((System.Drawing.Image)(resources.GetObject("btnArticle_1.Image")));
            this.btnArticle_1.Location = new System.Drawing.Point(12, 99);
            this.btnArticle_1.Name = "btnArticle_1";
            this.btnArticle_1.Size = new System.Drawing.Size(120, 120);
            this.btnArticle_1.TabIndex = 0;
            this.btnArticle_1.UseVisualStyleBackColor = true;
            this.btnArticle_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_caissier
            // 
            this.lbl_caissier.AutoSize = true;
            this.lbl_caissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_caissier.Location = new System.Drawing.Point(12, 18);
            this.lbl_caissier.Name = "lbl_caissier";
            this.lbl_caissier.Size = new System.Drawing.Size(81, 20);
            this.lbl_caissier.TabIndex = 1;
            this.lbl_caissier.Text = "Caissier :";
            this.lbl_caissier.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nom_caissier
            // 
            this.lbl_nom_caissier.AutoSize = true;
            this.lbl_nom_caissier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_nom_caissier.Location = new System.Drawing.Point(99, 18);
            this.lbl_nom_caissier.Name = "lbl_nom_caissier";
            this.lbl_nom_caissier.Size = new System.Drawing.Size(101, 20);
            this.lbl_nom_caissier.TabIndex = 2;
            this.lbl_nom_caissier.Text = "caissier test";
            // 
            // btnArticle_2
            // 
            this.btnArticle_2.Image = ((System.Drawing.Image)(resources.GetObject("btnArticle_2.Image")));
            this.btnArticle_2.Location = new System.Drawing.Point(12, 235);
            this.btnArticle_2.Name = "btnArticle_2";
            this.btnArticle_2.Size = new System.Drawing.Size(120, 120);
            this.btnArticle_2.TabIndex = 3;
            this.btnArticle_2.UseVisualStyleBackColor = true;
            // 
            // btnArticle_3
            // 
            this.btnArticle_3.Image = ((System.Drawing.Image)(resources.GetObject("btnArticle_3.Image")));
            this.btnArticle_3.Location = new System.Drawing.Point(12, 372);
            this.btnArticle_3.Name = "btnArticle_3";
            this.btnArticle_3.Size = new System.Drawing.Size(120, 120);
            this.btnArticle_3.TabIndex = 4;
            this.btnArticle_3.UseVisualStyleBackColor = true;
            this.btnArticle_3.Click += new System.EventHandler(this.btnArticle_3_Click);
            // 
            // frCaissePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 687);
            this.Controls.Add(this.btnArticle_3);
            this.Controls.Add(this.btnArticle_2);
            this.Controls.Add(this.lbl_nom_caissier);
            this.Controls.Add(this.lbl_caissier);
            this.Controls.Add(this.btnArticle_1);
            this.Name = "frCaissePrincipale";
            this.Text = "Écran principal";
            this.Load += new System.EventHandler(this.frCaissePrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArticle_1;
        private System.Windows.Forms.Label lbl_caissier;
        private System.Windows.Forms.Label lbl_nom_caissier;
        private System.Windows.Forms.Button btnArticle_2;
        private System.Windows.Forms.Button btnArticle_3;
    }
}

