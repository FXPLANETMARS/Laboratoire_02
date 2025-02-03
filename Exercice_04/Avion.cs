using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_04
{
    internal class Avion
    {
        string numeroDeVol;
        string destination;
        DateTime depart;
        int tempsRetard;

        public Avion(string numeroDeVol, string destination, DateTime depart)
        {
            this.numeroDeVol = numeroDeVol;
            this.destination = destination;
            this.depart = depart;
        }

        public int getTempsRetard()
        {
            return tempsRetard;
        }

        //méthode pour ajuster l'heure de départ en fonction du retard prévu
        public void NouvelleHeure(int minutes)
        {
            tempsRetard = minutes;
            depart = depart.AddMinutes(minutes);
        }

        public void VerifierEtatVol()
        {
            if (tempsRetard == 0)
            {
                Console.WriteLine($"Le vol {numeroDeVol}, est à l'heure");
            }
            else
            {
                Console.WriteLine($"Le vole {numeroDeVol}, est retardé de {tempsRetard} minutes.");
            }
        }

    }
}
