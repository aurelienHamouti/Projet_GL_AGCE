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
    public partial class frmGestionUtilisateurs : Form
    {
        public frmGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void btnAjouterUtilisateur_Click(object sender, EventArgs e)
        {
            frmAjouterUtilisateur frmAjouterUtilisateur = new frmAjouterUtilisateur();
            frmAjouterUtilisateur.ShowDialog();
            Dispose();
        }

        private void btnSupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            frmSupprimerUtilisateur frmSupprimerUtilisateur = new frmSupprimerUtilisateur();
            frmSupprimerUtilisateur.ShowDialog();
            Dispose();
        }

        private void btnModifierUtilisateur_Click(object sender, EventArgs e)
        {
            frmModifierUtilisateur frmModifierUtilisateur = new frmModifierUtilisateur();
            frmModifierUtilisateur.ShowDialog();
            Dispose();
        }

        private void btnDroitsUtilisateurs_Click(object sender, EventArgs e)
        {
            frmModifierDroitsUtilisateurs frmModifierDroitsUtilisateurs = new frmModifierDroitsUtilisateurs();
            frmModifierDroitsUtilisateurs.ShowDialog();
            Dispose();
        }
    }
}
