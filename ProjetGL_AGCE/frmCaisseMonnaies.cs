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
    public partial class frmCaisseMonnaies : Form
    {

        double montantTotal;
        int limiteNbChiffre;
        String devise;
        frmCaissePrincipale CaissePrincipale;

        public frmCaisseMonnaies(frmCaissePrincipale CaissePrincipale)
        {
            this.CaissePrincipale = CaissePrincipale;
            InitializeComponent();
            montantTotal = 0;
            limiteNbChiffre = 5;
            devise = "CHF";
            updateDevise();
            lblMonnaieTotal.Text = montantTotal.ToString();
        }

        public void updateDevise() { lblDevise.Text = devise; }

        public void updateDevise(String devise) {
            this.devise = devise;
            lblDevise.Text = devise;
        }

        private void btnDevise_Click(object sender, EventArgs e)
        {
            frmDevise frmDevise = new frmDevise(this);//appel singleton de le fenêtre des devise avec un référence sur le label courant
            frmDevise.ShowDialog();
        }

        private void lblDescriptionDevise_Click(object sender, EventArgs e)
        {

        }

        private void lblDevise_Click(object sender, EventArgs e)
        {

        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "1");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void frmCaisseMonnaies_Load(object sender, EventArgs e)
        {

        }

        private void btnMonnaieValidation_Click(object sender, EventArgs e)
        {
            CaissePrincipale.updateMontantTotal(montantTotal);
            Dispose();
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre)
            {
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "2");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre)
            {
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "3");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre)
            {
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "4");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "5");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "6");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "7");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "8");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < limiteNbChiffre){
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "9");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text !="" && lblMonnaieTotal.Text.Length < limiteNbChiffre) {
                montantTotal = Double.Parse(lblMonnaieTotal.Text + "0");
                lblMonnaieTotal.Text = montantTotal.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length >= 1){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text.Substring(0, lblMonnaieTotal.Text.Length - 1);//enlève le dernier charactère du prix
            }
            
        }

        private void btnVirgule_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length >= 1 && lblMonnaieTotal.Text.Length < limiteNbChiffre-1 && !lblMonnaieTotal.Text.Contains(".") )
            {
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + ".";
            }
        }
    }
}
