using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moyenne_v2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("**** Moyenne_v2 (V1.0, 17/08/16) ****");


            //déclaration de variables 
            int nombre;
            double moyenne;
            int somme = 0;
            int compteur = 0;


            do

            {
                Console.WriteLine("Entrez un nombre le 0 arrête la saisie");
                nombre = Int32.Parse(Console.ReadLine());
                somme = somme + nombre;
                if (nombre != 0)
                {
                    compteur++;
                }
            } while (nombre != 0);

            moyenne = (double)somme / (compteur);
            Console.WriteLine("La somme est de :" + somme);
            Console.WriteLine("Le compteur est de : " + compteur);
            Console.WriteLine("La moyenne est de :" + moyenne);
            Console.ReadLine();
        }
    }
}