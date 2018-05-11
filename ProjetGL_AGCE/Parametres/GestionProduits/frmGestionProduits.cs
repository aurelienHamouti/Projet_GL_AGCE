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
    public partial class frmGestionProduits : Form
    {
        public frmGestionProduits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAjouterProduit frmAjouterProduit = new frmAjouterProduit();
            frmAjouterProduit.ShowDialog();
            Dispose();
        }

        private void btnSuppressionProduit_Click(object sender, EventArgs e)
        {
            frmSupprimerProduit frmSupprimerProduit = new frmSupprimerProduit();
            frmSupprimerProduit.ShowDialog();
            Dispose();
        }

        private void btnSupprimerProduit_Click(object sender, EventArgs e)
        {
            frmModifierProduit frmModifierProduit = new frmModifierProduit();
            frmModifierProduit.ShowDialog();
            Dispose();
        }
    }
}
