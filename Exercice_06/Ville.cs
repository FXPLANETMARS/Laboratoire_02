using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_06
{
    internal class Ville
    {
        private string nom;
        private CoordGeo coord;
        int population;
        double longitude, latitude;


        public Ville(string nom, CoordGeo coord, int population)
        {
            this.nom = nom;
            this.coord = coord;
            this.population = population;
        }

        public void AfficherInfo()
        {
            Console.WriteLine($"\n\n\t\t Le nom de la ville est: {nom}\n\t\t Les coordonnées sont: ");

            coord.Affiche();

            Console.WriteLine($"\n\t\t La population de la villes est de: {population}");
        }
    
        public Ville(string nom)
        {
            this.nom = nom; 
            coord = new CoordGeo(nom);
        }

        public Ville(string nom, double longitude,  double latitude, int population)
        {
            this.nom = nom;
            this.longitude = longitude;
            this.latitude = latitude;
            this.population = population;
        }

        

    }
}
