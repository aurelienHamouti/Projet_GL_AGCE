using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGL_AGCE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Auteur : Aurélien Hamouti
        /// Date de réalisation : 05:04:2018
        /// Réaliseé dans le cadre des cours de la HEG Genève
        /// </summary>
        [STAThread]
        static void Main()
        {
            new metier.GestionnaireCaisse();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCaissePrincipale());
        }
    }
}
