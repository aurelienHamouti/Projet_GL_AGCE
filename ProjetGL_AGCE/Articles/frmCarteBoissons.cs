using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProjetGL_AGCE
{
    public partial class frmCarteBoissons : Form
    {
        private frmCaissePrincipale caissePrincipale;
        private double prixArticle1;
        private double prixArticle2;
        private double prixArticle3;
        private double prixArticle4;
        private double prixArticle5;
        private double prixArticle6;

        public frmCarteBoissons(frmCaissePrincipale caissePrincipale)
        {
            InitializeComponent();
            this.caissePrincipale = caissePrincipale;

            ArrayList listeBoissons = new ArrayList();
            listeBoissons = metier.GestionnaireCaisse.loadArticlesSelonCategorie("boissons");
            //boucle qui créer les btn selon info du gestionnaire
            //la boucle créer aussi les variables prix 
            prixArticle1 = ((domaine.Article)listeBoissons[0]).getPrix();
            prixArticle2 = ((domaine.Article)listeBoissons[1]).getPrix();
            prixArticle3 = ((domaine.Article)listeBoissons[2]).getPrix();
            prixArticle4 = ((domaine.Article)listeBoissons[3]).getPrix();
            prixArticle5  = ((domaine.Article)listeBoissons[4]).getPrix();
            prixArticle6 = ((domaine.Article)listeBoissons[5]).getPrix();
            initBtn(listeBoissons);
        }

        private void initBtn(ArrayList listeBoissons){
            btnArticleBoisson1.Text = prixArticle1 + ".-";
            btnArticleBoisson2.Text = prixArticle2 + ".-";
            btnArticleBoisson3.Text = prixArticle3 + ".-";
            btnArticleBoisson4.Text = prixArticle4 + ".-";
            btnArticleBoisson5.Text = prixArticle5 + ".-";
            btnArticleBoisson6.Text = prixArticle6 + ".-";
            btnArticleBoisson1.Image = ((domaine.Article)listeBoissons[0]).getImg();
            btnArticleBoisson2.Image = ((domaine.Article)listeBoissons[1]).getImg();
            btnArticleBoisson3.Image = ((domaine.Article)listeBoissons[2]).getImg();
            btnArticleBoisson4.Image = ((domaine.Article)listeBoissons[3]).getImg();
            btnArticleBoisson5.Image = ((domaine.Article)listeBoissons[4]).getImg();
            btnArticleBoisson6.Image = ((domaine.Article)listeBoissons[5]).getImg();
        }

        private void btnArticleBoissons1_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle1);
            Dispose();
        }

        private void btnArticleBoisson2_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle2);
            Dispose();
        }

        private void btnArticleBoisson3_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle3);
            Dispose();
        }

        private void btnArticleBoisson4_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle4);
            Dispose();
        }

        private void btnArticleBoisson5_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle5);
            Dispose();
        }

        private void btnArticleBoisson6_Click(object sender, EventArgs e)
        {
            caissePrincipale.addPrixArticle(prixArticle6);
            Dispose();
        }
    }
}
