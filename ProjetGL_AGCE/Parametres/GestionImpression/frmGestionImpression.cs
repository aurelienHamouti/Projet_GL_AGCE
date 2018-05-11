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
    public partial class frmGestionImpression : Form
    {
        public frmGestionImpression()
        {
            InitializeComponent();
        }

        private void btnImprimerParametres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paramètres imprimés !", "impression",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Dispose();
        }

        private void btnChoixImprimante_Click(object sender, EventArgs e)
        {

        }
    }
}
