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
    public partial class frmDevise : Form
    {
        Label devise;

        public frmDevise(Label devise)
        {
            InitializeComponent();
            this.devise = devise;
        }

        private void btnCHF_Click(object sender, EventArgs e)
        {
            devise.Text = "CHF";
            Dispose();
        }

        private void btnEUR_Click(object sender, EventArgs e)
        {
            devise.Text = "EUR";
            Dispose();
        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            devise.Text = "USD";
            Dispose();
        }
    }
}
