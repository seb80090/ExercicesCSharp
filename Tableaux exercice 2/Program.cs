using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_exercice_2
{
    class Program
    {
        static void Main()
        {
            

        }       
        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int nombre = Int32.Parse(Console.ReadLine());
            return nombre;

        }

        static void SaisieTab()

             {
            int[] tab = new int[10];
            
            
            Console.WriteLine("Entrez la taille du tableau");
            int taille = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < taille; i++)
            {
                Console.WriteLine("Entrez un nombre");
                tab[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < taille; i++)
            {
                Console.Write(tab[i] + " ");
            }
           
            }
        
    }
}

