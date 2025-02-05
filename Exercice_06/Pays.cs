using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_06
{
    internal class Pays
    {
        private string nom;
        private Ville capitale;
        Ville[] tabVille = new Ville[3];

        public Pays()
        {
            nom = "inconnu";
        }

        public Pays(Ville ville, string nom)
        {
            this.capitale = ville;
            this.nom = nom;
        }

        public Pays(string nom, string capitale, Ville ville1, Ville ville2, Ville ville3)
        {
            this.nom = nom;
            this.capitale = new Ville(capitale);
            tabVille[0] = ville1;
            tabVille[1] = ville2;
            tabVille[2] = ville3;
        }

        public void AfficherInfo1()
        {
            Console.WriteLine($"\n\n\t\t Le nom du pays est:" +
                $" {nom}\n\t\t La capitale est: ");
            capitale.AfficherInfo();

            Console.WriteLine("\n\n\t\tLes villes sont: ");
            tabVille[0].AfficherInfo();
            tabVille[1].AfficherInfo();
            tabVille[2].AfficherInfo();
        }

    }
}
