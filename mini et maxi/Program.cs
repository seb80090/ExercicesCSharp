using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** mini et max (V1.0, 17/08/16) ****");
            //déclaration de variables 
            int nombre;
            int somme = 0;
            int min = 0;
            int max = 0;
            int compteur = 0;
            double moyenne;
            do
            {
                Console.WriteLine("Entrez un nombre (0 pour arreter la saisie) :");
                nombre = Int32.Parse(Console.ReadLine());
                somme = nombre + somme; //somme += nombre
                if (compteur == 0)//la condition est valide uniquement lors de la premiere saisie du nombre
                {
                    min = nombre;
                    max = nombre;
                }

                if (nombre < min & nombre != 0)//permet de sortir la valeur minimum en excluant la valeur 0
                {
                    min = nombre;
                }

                if (nombre > max)//permet de sortir la valeur maximum
                {
                    max = nombre;
                }

                if (nombre != 0)//compte le nombre de nombre entré en excluant le 0
                {
                    compteur++;
                }
            } while (nombre != 0);
            moyenne = (double)somme / compteur;
            Console.WriteLine("La moyenne est de : " + moyenne);
            Console.WriteLine("La somme est de : " + somme);
            Console.WriteLine("La valeur maximale est de : " + max);
            Console.WriteLine("La valeur minimale est de : " + min);
            Console.ReadLine();

        }
    }
}