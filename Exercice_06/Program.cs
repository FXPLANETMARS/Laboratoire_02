using System.Security.Cryptography.X509Certificates;

namespace Exercice_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoordGeo coordGeo = new CoordGeo();

            Ville ville1 = new Ville("Quito");

            Pays pays1 = new Pays(ville1, "Équateur");

            Ville v1 = new Ville("Montreal", 45.30, -73.33, 2000000);
            Ville v2 = new Ville("Toronto");
            Ville v3 = new Ville("Vancouver", coordGeo , 1000000);

            Pays p1 = new Pays("Canada" , "Toronto" , v1 , v2 , v3);


            p1.AfficherInfo1();
            v1.AfficherInfo();
            v2.AfficherInfo();
            v3.AfficherInfo();
        }
    }
}
