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
    public partial class frmParametres : Form
    {
        public frmParametres()
        {
            InitializeComponent();
        }

        private void btnGestionProduit_Click(object sender, EventArgs e)
        {
            frmGestionProduits frmGestionProduits = new frmGestionProduits();
            frmGestionProduits.ShowDialog();
        }

        private void btnGestionUtilisateurs_Click(object sender, EventArgs e)
        {
            frmGestionUtilisateurs frmGestionUtilisateurs = new frmGestionUtilisateurs();
            frmGestionUtilisateurs.ShowDialog();
        }

        private void btnGestionDesStocks_Click(object sender, EventArgs e)
        {
            frmGestionStocks frmGestionStocks = new frmGestionStocks();
            frmGestionStocks.ShowDialog();
        }

        private void btnParametresImpression_Click(object sender, EventArgs e)
        {
            frmGestionImpression frmGestionImpression = new frmGestionImpression();
            frmGestionImpression.ShowDialog();
        }

        private void btnGestionHistoriques_Click(object sender, EventArgs e)
        {
            frmGestionHistorique frmGestionHistorique = new frmGestionHistorique();
            frmGestionHistorique.ShowDialog(); 
        }
    }
}
