using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_02
{
    internal class Employe
    {
            string nom;
            DateTime DateDembauche;
            decimal salaire;

            public Employe(string nom, DateTime DateDembauche, decimal salaire)
            {
            this.nom = nom;
            this.DateDembauche = DateDembauche;
            this.salaire = salaire;
            }
        
        public void AfficherInfo()
        {
            Console.WriteLine("Le nom de l'employé est : " + nom);
            Console.WriteLine("La date d'embauche est : " + DateDembauche.ToString("yyyy-MM-dd"));
            Console.WriteLine("Le salaire de l'employé est : " + salaire);
        }

        public int CalculerAnneService()
        {
            return DateTime.Now.Year - DateDembauche.Year;
        }

    }

    
}
