using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyelles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** nombre de voyelles (V1.0, 22/08/16) ****");
            //déclaration de variables 
            string mot;
            int compteur = 0;
            string voyelles = "aeiouyAEIOUYéàèâûîô";

            Console.WriteLine("Entrez un mot");
            mot = Console.ReadLine();

            for (int i = 0; i < mot.Length; i++)
            {
                string l = mot.Substring(i, 1);
                if (voyelles.IndexOf(l) != -1)
                {
                    compteur++;
                }

            }

            Console.WriteLine("Voyelles = " + compteur);
            Console.ReadLine();
        }
    }
}
