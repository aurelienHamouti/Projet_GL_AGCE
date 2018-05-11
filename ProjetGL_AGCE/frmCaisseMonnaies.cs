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
        public frmCaisseMonnaies()
        {
            InitializeComponent();
        }

        private void btnDevise_Click(object sender, EventArgs e)
        {
            frmDevise frmDevise = new frmDevise(lblDevise);
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
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "1";
            }
        }

        private void frmCaisseMonnaies_Load(object sender, EventArgs e)
        {

        }

        private void btnMonnaieValidation_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "2";
            }
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "3";
            }
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "4";
            }
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "5";
            }
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5)
            {
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "6";
            }
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "7";
            }
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "8";
            }
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text.Length < 5){
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "9";
            }
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (lblMonnaieTotal.Text !="" && lblMonnaieTotal.Text.Length < 5) {
                lblMonnaieTotal.Text = lblMonnaieTotal.Text + "0";
            }
        }
    }
}
