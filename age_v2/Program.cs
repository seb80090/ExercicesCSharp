using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**** age (V.0, 18/08/16) ****");

            //déclaration des variables
            int annee;
            int age;
            DateTime datedujour = DateTime.Today;

            Console.WriteLine("Entrez votre année de naissance");
            annee = Int32.Parse(Console.ReadLine());

            age = (annee - datedujour);

            if

                (age > 18) 
            {
                Console.WriteLine("Vous êtes majeur");
            }

            else
            {
                Console.WriteLine("Vous êtes mineur");
            }
            Console.ReadLine();



        }

    }
}

