using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_03
{
    internal class FeuDeCirculation
    {
        int duree;
        string couleur;


        public FeuDeCirculation(string couleur, int duree) 
        {
            this.couleur = couleur;
            this.duree = duree;
        }

        public int Duree { get => duree; set => duree = value; }

        public string GetCouleur()
        {
            return couleur;
        }

        public void SetCouleur(string couleur)
        {
            this.couleur = couleur;
        }
        public bool EstVert()
        {
            //retourne true si est verte, sinon retoure false
            return couleur == "vert";
        }

        public bool EstRouge()
        {
            //retourne true si la couleur est rouge, sinon retourne false
            return couleur == "rouge";
        }


    }
}
