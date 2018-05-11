namespace ProjetGL_AGCE
{
    partial class frmDevise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevise));
            this.btnCHF = new System.Windows.Forms.Button();
            this.btnEUR = new System.Windows.Forms.Button();
            this.btnUSD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCHF
            // 
            this.btnCHF.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnCHF.Location = new System.Drawing.Point(15, 26);
            this.btnCHF.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCHF.Name = "btnCHF";
            this.btnCHF.Size = new System.Drawing.Size(75, 41);
            this.btnCHF.TabIndex = 0;
            this.btnCHF.Text = "CHF";
            this.btnCHF.UseVisualStyleBackColor = true;
            this.btnCHF.Click += new System.EventHandler(this.btnCHF_Click);
            // 
            // btnEUR
            // 
            this.btnEUR.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnEUR.Location = new System.Drawing.Point(108, 26);
            this.btnEUR.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnEUR.Name = "btnEUR";
            this.btnEUR.Size = new System.Drawing.Size(75, 41);
            this.btnEUR.TabIndex = 1;
            this.btnEUR.Text = "EUR";
            this.btnEUR.UseVisualStyleBackColor = true;
            this.btnEUR.Click += new System.EventHandler(this.btnEUR_Click);
            // 
            // btnUSD
            // 
            this.btnUSD.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.btnUSD.Location = new System.Drawing.Point(201, 26);
            this.btnUSD.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnUSD.Name = "btnUSD";
            this.btnUSD.Size = new System.Drawing.Size(75, 41);
            this.btnUSD.TabIndex = 2;
            this.btnUSD.Text = "USD";
            this.btnUSD.UseVisualStyleBackColor = true;
            this.btnUSD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // frmDevise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 91);
            this.ControlBox = false;
            this.Controls.Add(this.btnUSD);
            this.Controls.Add(this.btnEUR);
            this.Controls.Add(this.btnCHF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "frmDevise";
            this.Text = " Devises";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCHF;
        private System.Windows.Forms.Button btnEUR;
        private System.Windows.Forms.Button btnUSD;
    }
}