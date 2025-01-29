namespace Exercice_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Employe employe = new Employe("NoNo", new DateTime(2024, 05, 01), 80000);

            Console.WriteLine($"Voici les informations: ");
            employe.AfficherInfo();

            Console.WriteLine($"Années de service: {employe.CalculerAnneService()}");
            
        }
    }
}
