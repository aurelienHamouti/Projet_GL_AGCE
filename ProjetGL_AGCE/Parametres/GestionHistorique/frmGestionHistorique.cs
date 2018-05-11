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
    public partial class frmGestionHistorique : Form
    {
        public frmGestionHistorique()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AffichageHistoriqueUtilisateur AffichageHistoriqueUtilisateur = new AffichageHistoriqueUtilisateur();
            AffichageHistoriqueUtilisateur.ShowDialog();
            Dispose();
        }

        private void btnAfficherVentes_Click(object sender, EventArgs e)
        {
            frmAffichageHistoriqueVentes frmAffichageHistoriqueVentes = new frmAffichageHistoriqueVentes();
            frmAffichageHistoriqueVentes.ShowDialog();
            Dispose();
        }

        private void btnAfficherStocks_Click(object sender, EventArgs e)
        {
            frmAffichageHistoriqueStock frmAffichageHistoriqueStock = new frmAffichageHistoriqueStock();
            frmAffichageHistoriqueStock.ShowDialog();
            Dispose();
        }
    }
}
