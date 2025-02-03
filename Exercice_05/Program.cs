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

            Equation1.CalculerDiscriminant();

            Equation1.TrouverX1();
            Equation1.TrouverX2();

            Equation1.Resultat();
        }
    }
}
