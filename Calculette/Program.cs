using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** calculette (V1.0, 25/07/16) ****");
            int nombre1, nombre2, resultat;
            string operateur;

            Console.WriteLine("Entrez un nombre");
            nombre1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un deuxième nombre");
            nombre2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez un opérateur");
            operateur = Console.ReadLine();

            switch (operateur)
            {
                case "+":
                    resultat = nombre1 + nombre2;
                    Console.WriteLine("Le résultat de l'opération est :" + resultat);
                    Console.ReadLine();
                    break;

                case "-":
                    resultat = nombre1 - nombre2;
                    Console.WriteLine("Le résultat de l'opération est :" + resultat);
                    Console.ReadLine();
                    break;

                case "*":
                    resultat = nombre1 * nombre2;
                    Console.WriteLine("Le résultat de l'opération est :" + resultat);
                    Console.ReadLine();
                    break;

                case "/":
                    if (nombre2 == 0)
                    {
                        Console.WriteLine("Le nombre que vous avez rentré ne peux être divisé par 0");
                        Console.ReadLine();
                    }
                    else
                    {
                        resultat = nombre1 / nombre2;
                        Console.WriteLine("Le résultat de l'opération est :" + resultat);
                        Console.ReadLine();
                    }
                    break;


                default:
                    Console.WriteLine("opération impossible");
                    Console.ReadLine();
                    break;
            }

            // Console.WriteLine("Le résultat de l'opération est :" + resultat);
            // Console.ReadLine();

        }
    }
}