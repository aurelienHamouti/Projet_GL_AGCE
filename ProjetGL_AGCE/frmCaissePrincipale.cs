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
    public partial class frmCaissePrincipale : Form
    {
        public frmCaissePrincipale()
        {
            InitializeComponent();
        }

        private void frmCaissePrincipale_Load(object sender, EventArgs e)
        {
            /*frLogin frLogin = new frLogin();
            frLogin.ShowDialog();
            btnEncaissement.Enabled = false;
            btnImprimerQuittance.Enabled = false;
            btnListeDesVentes.Enabled = false;
            btnParametres.Enabled = false;*/
        }

        public void activationFonctionsBasiques() {
            btnEncaissement.Enabled = true;
            btnImprimerQuittance.Enabled = true;
            btnListeDesVentes.Enabled = true;
            btnParametres.Enabled = true;
        }


        private void btnConnectionCaissePrincipale_Click(object sender, EventArgs e)
        {
            frmLogin frLogin = new frmLogin(lblCaissierConnecte);
            frLogin.ShowDialog();
        }

        private void btnImprimerQuittance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quittance imprimée !", "Impression quittance",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }


        private void btnEncaissement_Click(object sender, EventArgs e)
        {
            frmCaisseMonnaies frmCaisseMonnaies = new frmCaisseMonnaies();
            frmCaisseMonnaies.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCarteNettoyage frmCarteNettoyage = new frmCarteNettoyage();
            frmCarteNettoyage.ShowDialog();
        }

        private void btnListeDesVentes_Click(object sender, EventArgs e)
        {
            frmListeVentes frmListeVentes = new frmListeVentes();
            frmListeVentes.ShowDialog();
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            frmParametres frmParametres = new frmParametres();
            frmParametres.ShowDialog();
        }

        private void btnTypeArticlesBoissons_Click(object sender, EventArgs e)
        {

            frmCarteBoissons frmCarteBoissons = new frmCarteBoissons();
            frmCarteBoissons.ShowDialog();
        }

        private void btnTypeArticlesSnack_Click(object sender, EventArgs e)
        {
            frmCarteSnacks frmCarteSnacks = new frmCarteSnacks();
            frmCarteSnacks.ShowDialog();
        }

        private void btnTypeArticlesSandwichs_Click(object sender, EventArgs e)
        {
            frmCarteSandwichs frmCarteSandwichs = new frmCarteSandwichs();
            frmCarteSandwichs.ShowDialog();
        }

        private void btnTypeArticlesRepas_Click(object sender, EventArgs e)
        {
            frmCarteRepas frmCarteRepas = new frmCarteRepas();
            frmCarteRepas.ShowDialog();
        }

        private void btnTypeArticlesSoins_Click(object sender, EventArgs e)
        {
            frmSoinsCosmetiques frmSoinsCosmetiques = new frmSoinsCosmetiques();
            frmSoinsCosmetiques.ShowDialog();
        }

        private void btnTypeArticlePetiteFourniture_Click(object sender, EventArgs e)
        {
            frmPetiteFourniture frmPetiteFourniture = new frmPetiteFourniture();
            frmPetiteFourniture.ShowDialog();
        }

        private void btnQuitterApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
