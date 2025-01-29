using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_01
{
    internal class Complexe
    {
        double valeurReelle, valeurImaginaire;

        public Complexe(double valeurReelle, double valeurImaginaire)
        {
            this.valeurReelle = valeurReelle;
            this.valeurImaginaire = valeurImaginaire;
        }


        //Mutateurs pour ValeurReelle
        public double GetValeurReelle()
        {
            return valeurReelle;
        }

        //Accesseur pour ValeurReelle
        public void SetValeurReelle(double valeurReelle)
        {
            this.valeurReelle = valeurReelle;
        }
        //Mutateur et accesseur pour ValeurImaginaire

        public double ValeurImaginaire { get => valeurImaginaire; set => valeurImaginaire = value; }

        //Méthode qui retourne les valeurs
        public string AfficherValeurs()
        {
            return "( "+valeurReelle+" , "+valeurImaginaire+" )";
        }

        //Méthode qui affiche l'ordre de grandeur du complex

        public double GetMagnitude()
        {
            return Math.Sqrt((valeurReelle*valeurReelle)+ (valeurImaginaire*valeurImaginaire));
        }

        //Méthode qui fait la somme de deux nombres complexes

        public void AdditionnerComplexe(Complexe complex2)
        {
            valeurReelle += complex2.valeurReelle;
            valeurImaginaire += complex2.ValeurImaginaire;
        }
    }
}
