namespace Exercice_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, discriminant;

            Console.WriteLine("Entrez la valeur de a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la valeur de b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la valeur de c");
            c = double.Parse(Console.ReadLine());

            RecupDeDonnees Equation1 = new RecupDeDonnees(a, b, c);
            Equation1.AfficherEquation();

            discriminant = Equation1.CalculerDiscriminant();

            Console.WriteLine($"Le discriminant est: {discriminant}");


            double x1 = Equation1.TrouverX1();
            double x2 = Equation1.TrouverX2();
            
            if (discriminant > 0)
            {
                Console.WriteLine($"Il y a deux racines distinctes et elles sont:\n\n x1:{x1} \n\n x2:{x2}");
            }
            else if (discriminant < 0)
            {
                Console.WriteLine($"Il n'y a pas de solution réelles.");
            }
            else
            {
                Console.WriteLine("Il y a une racine réelle double.");
                    double racine = (-b) / (2 * a);
                Console.WriteLine(racine);
            }
        }
    }
}
