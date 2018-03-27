namespace ProjetGL_AGCE
{
    partial class frLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frLogin));
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblAccueilLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConnectionLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Location = new System.Drawing.Point(12, 82);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(61, 13);
            this.lblUsernameLogin.TabIndex = 0;
            this.lblUsernameLogin.Text = "Username :";
            this.lblUsernameLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(12, 129);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(59, 13);
            this.lblPasswordLogin.TabIndex = 1;
            this.lblPasswordLogin.Text = "Password :";
            // 
            // lblAccueilLogin
            // 
            this.lblAccueilLogin.AutoSize = true;
            this.lblAccueilLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilLogin.Location = new System.Drawing.Point(12, 18);
            this.lblAccueilLogin.Name = "lblAccueilLogin";
            this.lblAccueilLogin.Size = new System.Drawing.Size(190, 13);
            this.lblAccueilLogin.TabIndex = 2;
            this.lblAccueilLogin.Text = "Veuillez rentrer vos identifiants :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnConnectionLogin
            // 
            this.btnConnectionLogin.Location = new System.Drawing.Point(144, 172);
            this.btnConnectionLogin.Name = "btnConnectionLogin";
            this.btnConnectionLogin.Size = new System.Drawing.Size(86, 26);
            this.btnConnectionLogin.TabIndex = 5;
            this.btnConnectionLogin.Text = "Connection";
            this.btnConnectionLogin.UseVisualStyleBackColor = true;
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(244, 212);
            this.Controls.Add(this.btnConnectionLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAccueilLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Écran de connection";
            this.Load += new System.EventHandler(this.frLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblAccueilLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConnectionLogin;
    }
}