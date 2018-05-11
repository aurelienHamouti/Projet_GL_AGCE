namespace ProjetGL_AGCE
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsernameLogin = new System.Windows.Forms.Label();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.lblAccueilLogin = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectionLogin = new System.Windows.Forms.Button();
            this.btnQuitterProgramme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsernameLogin
            // 
            this.lblUsernameLogin.AutoSize = true;
            this.lblUsernameLogin.Location = new System.Drawing.Point(10, 71);
            this.lblUsernameLogin.Name = "lblUsernameLogin";
            this.lblUsernameLogin.Size = new System.Drawing.Size(61, 13);
            this.lblUsernameLogin.TabIndex = 0;
            this.lblUsernameLogin.Text = "Username :";
            this.lblUsernameLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(12, 108);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(59, 13);
            this.lblPasswordLogin.TabIndex = 1;
            this.lblPasswordLogin.Text = "Password :";
            // 
            // lblAccueilLogin
            // 
            this.lblAccueilLogin.AutoSize = true;
            this.lblAccueilLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueilLogin.Location = new System.Drawing.Point(10, 19);
            this.lblAccueilLogin.Name = "lblAccueilLogin";
            this.lblAccueilLogin.Size = new System.Drawing.Size(155, 13);
            this.lblAccueilLogin.TabIndex = 3;
            this.lblAccueilLogin.Text = "Veuillez rentrer vos identifiants :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(76, 71);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 108);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnConnectionLogin
            // 
            this.btnConnectionLogin.Location = new System.Drawing.Point(142, 168);
            this.btnConnectionLogin.Name = "btnConnectionLogin";
            this.btnConnectionLogin.Size = new System.Drawing.Size(86, 26);
            this.btnConnectionLogin.TabIndex = 2;
            this.btnConnectionLogin.Text = "Connection";
            this.btnConnectionLogin.UseVisualStyleBackColor = true;
            this.btnConnectionLogin.Click += new System.EventHandler(this.btnConnectionLogin_Click);
            // 
            // btnQuitterProgramme
            // 
            this.btnQuitterProgramme.Location = new System.Drawing.Point(14, 168);
            this.btnQuitterProgramme.Name = "btnQuitterProgramme";
            this.btnQuitterProgramme.Size = new System.Drawing.Size(86, 26);
            this.btnQuitterProgramme.TabIndex = 4;
            this.btnQuitterProgramme.Text = "Quitter ";
            this.btnQuitterProgramme.UseVisualStyleBackColor = true;
            this.btnQuitterProgramme.Click += new System.EventHandler(this.btnQuitterProgramme_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(246, 210);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitterProgramme);
            this.Controls.Add(this.btnConnectionLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblAccueilLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.lblUsernameLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " Connection";
            this.Load += new System.EventHandler(this.frLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameLogin;
        private System.Windows.Forms.Label lblPasswordLogin;
        private System.Windows.Forms.Label lblAccueilLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnectionLogin;
        private System.Windows.Forms.Button btnQuitterProgramme;
    }
}