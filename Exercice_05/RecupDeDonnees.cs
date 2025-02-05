using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_05
{
    internal class RecupDeDonnees
    {
       double a, b, c, x, discriminant;
        public RecupDeDonnees(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void AfficherEquation()
        {
            Console.WriteLine($"Selon l'équation ax2 + bx + c = 0\n\n {a}x2 + {b}x + {c} = 0");

        }

        public double CalculerDiscriminant()
        {
            discriminant = (b * b) - (4 * (a * c));
            return discriminant;
        }

        public double TrouverX1()
        {
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            return x1;
        }

        public double TrouverX2()
        {
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return x2;
        }

        public void Resultat()
        {
            switch (discriminant)
            {
                case 0:
                    if (discriminant > 0)
                    {
                        Console.WriteLine("Il y a deux racines disctinctes");
                    }
                    break;

                case 1:
                    discriminant = 0; Console.WriteLine("Il y a une racine réelle double");
                    break;

                case 2:
                    if (discriminant < 0)
                    {
                        Console.WriteLine("Il n'y a pas de solution réelle");
                    }
                    break;

             }
        }
    }
}
