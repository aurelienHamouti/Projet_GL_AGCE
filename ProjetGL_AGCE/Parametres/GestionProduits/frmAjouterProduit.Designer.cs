namespace ProjetGL_AGCE
{
    partial class frmAjouterProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterProduit));
            this.lblNumeroProduit = new System.Windows.Forms.Label();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.lblPrixProduit = new System.Windows.Forms.Label();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAnnulerAjoutProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroProduit
            // 
            this.lblNumeroProduit.AutoSize = true;
            this.lblNumeroProduit.Location = new System.Drawing.Point(14, 20);
            this.lblNumeroProduit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNumeroProduit.Name = "lblNumeroProduit";
            this.lblNumeroProduit.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroProduit.TabIndex = 0;
            this.lblNumeroProduit.Text = "Numéro du produit";
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Location = new System.Drawing.Point(14, 78);
            this.lblNomProduit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(79, 13);
            this.lblNomProduit.TabIndex = 2;
            this.lblNomProduit.Text = "Nom du produit";
            // 
            // lblPrixProduit
            // 
            this.lblPrixProduit.AutoSize = true;
            this.lblPrixProduit.Location = new System.Drawing.Point(14, 142);
            this.lblPrixProduit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPrixProduit.Name = "lblPrixProduit";
            this.lblPrixProduit.Size = new System.Drawing.Size(74, 13);
            this.lblPrixProduit.TabIndex = 4;
            this.lblPrixProduit.Text = "Prix du produit";
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.Location = new System.Drawing.Point(147, 218);
            this.btnAjouterProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(87, 31);
            this.btnAjouterProduit.TabIndex = 6;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = true;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 100);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 164);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btnAnnulerAjoutProduit
            // 
            this.btnAnnulerAjoutProduit.Location = new System.Drawing.Point(16, 218);
            this.btnAnnulerAjoutProduit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnAnnulerAjoutProduit.Name = "btnAnnulerAjoutProduit";
            this.btnAnnulerAjoutProduit.Size = new System.Drawing.Size(90, 31);
            this.btnAnnulerAjoutProduit.TabIndex = 7;
            this.btnAnnulerAjoutProduit.Text = "Annuler";
            this.btnAnnulerAjoutProduit.UseVisualStyleBackColor = true;
            this.btnAnnulerAjoutProduit.Click += new System.EventHandler(this.btnAnnulerAjoutProduit_Click);
            // 
            // frmAjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 266);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnulerAjoutProduit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAjouterProduit);
            this.Controls.Add(this.lblPrixProduit);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.lblNumeroProduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmAjouterProduit";
            this.Text = " Ajouter produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroProduit;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.Label lblPrixProduit;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAnnulerAjoutProduit;
    }
}