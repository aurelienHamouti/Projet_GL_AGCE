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
        frmCaisseMonnaies frm;

        public frmDevise(frmCaisseMonnaies frmCaisseMonnaies)
        {
            InitializeComponent();
            this.frm = frmCaisseMonnaies;
            //Amélioration -> va chercher les infos dans la db (num et description devise)
        }

        private void btnCHF_Click(object sender, EventArgs e)
        {
            frm.updateDevise("CHF");
            Dispose();
        }

        private void btnEUR_Click(object sender, EventArgs e)
        {
            frm.updateDevise("EUR");
            Dispose();
        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            frm.updateDevise("USD");
            Dispose();
        }
    }
}
