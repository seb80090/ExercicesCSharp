using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Multiples (V1.0, 17/08/16) ****");
            //déclaration de variables 
            int n = 0;
            int x = 0;
            int resultat;
            int i = 1;
            
            
                Console.WriteLine("Entrez un nombre");
                n = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Entrez un multiple:");
                x = Int32.Parse(Console.ReadLine());

                while (i != (n+1)) 
                {
                    resultat = (i * x);
                    Console.WriteLine( i +"x" + x +"=" + resultat);
                    i++;
                }
            

            Console.ReadLine();

            }
      }
    }
            