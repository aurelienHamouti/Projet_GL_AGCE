using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGL_AGCE
{
    public partial class frmLogin : Form
    {
        Label caissier;

        public frmLogin(Label caissier)
        {
            InitializeComponent();
            this.caissier = caissier;
        }

        private void frLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectionLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "welcomeAGCE")
            {
                caissier.Text = txtUsername.Text;
                Dispose();
            }else{
                MessageBox.Show("Mot de passe erroné ! Veuillez consulter la documentation fournie", "Mauvais mot de passe",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnQuitterProgramme_Click(object sender, EventArgs e)
        {
            Dispose();
            //Application.Exit();
        }
    }
}
