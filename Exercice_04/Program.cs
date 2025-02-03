namespace Exercice_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion AirCanada = new Avion("ABT56", "Bruxelles", new DateTime(2025, 09, 4, 11, 30, 0));
            //Afficher le statut initial du vol
            //AirCanada.VerifierEtatVol();

            //Nous allons retarder le vol de 30 minutes maintenant.
            AirCanada.NouvelleHeure(30);

            //Affichage du statut révisé du vol
            AirCanada.VerifierEtatVol();


        }
    }
}
