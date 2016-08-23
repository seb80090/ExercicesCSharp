using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette_v2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("*** Calculette (V2.0, 18/08/2016***");
            //déclaration des variables
            int n1;
            int n2;
            int resultat;
            string operateur;


            Console.WriteLine("saisir un premier nombre");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("saisir un second nombre");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un opérateur");
            operateur = Console.ReadLine();

            switch (operateur)
            {
                case "+":
                    resultat = (n1 + n2);
                    Console.WriteLine("le resultat de l'opération est" + resultat);

                    break;

                case "-":
                    resultat = (n1 + n2);
                    Console.WriteLine("le resultat de l'opération est" + resultat);

                    break;

                case "*":
                    resultat = (n1 * n2);
                    Console.WriteLine("le resultat de l'opération est" + resultat);

                    break;

                case "/":            
                    if (n2 == 0)
                        {
                            Console.WriteLine("Le nombre que vous avez rentré ne peux être divisé par 0");
                            Console.ReadLine();
                         }
                    else
                    {
                        resultat = (n1 * n2);
                        Console.WriteLine("le resultat de l'opération est" + resultat);
                    }
                    break;


                default:
                    Console.WriteLine("opération impossible");
                Console.ReadLine();
                break;
            }


            }



       }
    }

