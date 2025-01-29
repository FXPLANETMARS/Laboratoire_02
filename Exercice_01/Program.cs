using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Exercice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complexe complex1 = new Complexe(5, 8);
            Console.WriteLine($"Le nombre est : {complex1.AfficherValeurs()}");

            Console.WriteLine("Addition de deux nombres ");

            var/* var remplace le type "Complexe"*/complex2 = new Complexe(-2, 3);//Crée un nombre complex2 var remplace le type "Complexe"

            complex1.AdditionnerComplexe(complex2);//Addition complex1 avec un autre nombre complexe2

            Console.WriteLine($"L'addition du nombre est : {complex1.AfficherValeurs()}");
        }
    }
}
