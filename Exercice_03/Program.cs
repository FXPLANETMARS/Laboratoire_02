namespace Exercice_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var feucirculation = new FeuDeCirculation("Rouge", 30);

            //Changement de l'état du feu
            feucirculation.SetCouleur("vert");
            //modifie la durée du feu de circulation
            if (feucirculation.EstVert())
            {
                Console.WriteLine("Le feu de circulation est vert");
            }
            else
            {
                Console.WriteLine("Le feu de circulation est rouge");
            }
        
        }
    }
}
