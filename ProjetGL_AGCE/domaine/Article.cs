using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProjetGL_AGCE.domaine
{
    class Article
    {
        private int no;
        private String nom;
        private double prix;
        private String description;
        private Image img;
        private String categorie;

        public Article(int no, String nom, double prix, String description, Image img, String categorie)
        {
            this.no = no;
            this.nom = nom;
            this.prix = prix;
            this.description = description;
            this.img = img;
            this.categorie = categorie;
        }

        public int getNo() { return this.no; }

        public String getNom() { return this.nom; }

        public double getPrix() { return this.prix; }

        public String getDescription() { return this.description; }

        public Image getImg() { return this.img; }

        public String getCategorie() { return this.categorie; }

        public String toString() { return nom; }
    }
}
