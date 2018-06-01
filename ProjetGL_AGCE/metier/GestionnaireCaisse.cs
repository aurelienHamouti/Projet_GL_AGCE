using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjetGL_AGCE.metier
{
    class GestionnaireCaisse //cette classe sert à gérer les vues relatif à la caisse et à faire la lien avec le DAO
    {
        //private frmCaissePrincipale CaissePrincipale; //Règle de gestion - Une seule intance de caisse principale à la fois
        //private frmCaisseMonnaies CaissesMonnaies; //Règle de gestion - Une seule intance de caisse monnaies à la fois

        private static ArrayList listeArticles = new ArrayList();


        public GestionnaireCaisse() {
            loadListeArticle();
        }


        //DAO
        public void loadListeArticle() {
            listeArticles = new dao.DaoArticles().loadArticles();
        }

        public static ArrayList loadArticlesSelonCategorie(String categorie) {
            ArrayList listeBoissons = new ArrayList();
            for (int i = 0; i < listeArticles.Count; i++) {
                domaine.Article a = (domaine.Article)listeArticles[i];
                if (a.getCategorie().Equals(categorie)) {
                    listeBoissons.Add(listeArticles[i]);
                }    
            }
            return listeBoissons;
        }


    }
}
