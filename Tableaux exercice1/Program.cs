using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];

            //tab[15] = 7;

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