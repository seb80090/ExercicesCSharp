using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** age (V1.0, 18/08/16) ****");
            
            //déclaration de variables
            int annee, age;
            DateTime datedujour = DateTime.Today;
            
            Console.WriteLine("Veuillez entrez votre année de naissance");
            annee = Int32.Parse(Console.ReadLine());
            age = datedujour.Year - annee;
            if (age >= 18)
            { Console.WriteLine("Vous êtes majeur"); }
            else
            {
                Console.WriteLine("Vous êtes mineur");


            }
            Console.ReadLine();
        }
    }
}
