using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_06
{
    internal class CoordGeo
    {
        private string Greenwich, SaintJerome, Sydney,
            Ottawa, Toronto, Vancouver, Quito;

        double longitude, latitude;

        public CoordGeo(double longitude, double latitude)
        {
            this.latitude = latitude;
            this.longitude = longitude; 
        }

        public CoordGeo()
        {
            latitude = 0;
            longitude = 0;
        }

        public void Affiche()
        {
            Console.WriteLine($"\n\n\t\t La Longitude est de: {longitude}\n\t\t La latitude est de: {latitude}");
        }

        public CoordGeo(string ville)
        {
            if (ville == Greenwich)
            {
                latitude = 51.482578;
                longitude = -0.007659;
            }
            else if (ville == SaintJerome)
            {
                latitude = 45.777679;
                longitude = -74.004021;
            }
            else if (ville == Sydney)
            {
                latitude = -33.868820;
                longitude = 151.209290;
            }
            else if (ville == Ottawa)
            {
                latitude = 45.421532;
                longitude = -75.697189;
            }
            else if (ville == Quito)
            {
                latitude = -0.180653;
                longitude = -78.467834;
            }
            else if (ville == Toronto)
            {
                latitude = 43.6516053;
                longitude = -79.3831254;
            }
            else if (ville == Vancouver)
            {
                latitude = 49.2604134;
                longitude = -123.1139456;
            }
            if (ville == "")
            {
                latitude = 0;
                longitude = 0;
            }
        }

        
    }
}
