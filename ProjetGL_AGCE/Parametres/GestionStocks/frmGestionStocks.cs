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
    public partial class frmGestionStocks : Form
    {
        public frmGestionStocks()
        {
            InitializeComponent();
        }

        private void btnAjouterArticles_Click(object sender, EventArgs e)
        {
            frmAjouterStock frmAjouterStock = new frmAjouterStock();
            frmAjouterStock.ShowDialog();
            Dispose();
        }

        private void btnEnleverArticle_Click(object sender, EventArgs e)
        {
            frmSupprimerStock frmSupprimerStock = new frmSupprimerStock();
            frmSupprimerStock.ShowDialog();
            Dispose();
        }
    }
}
