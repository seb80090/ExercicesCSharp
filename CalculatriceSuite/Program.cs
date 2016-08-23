using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatrice
{
    class Program
    {


        static void Main()
        {
            Console.Write("**** CALCULATRICE SUITE (V1.0, 16/08/16) ****");
            string saisie1;
            string saisie2;
            double nombre1;
            double nombre2;
            double resultat;

            Console.WriteLine("Entrez le nombre1: ");
            saisie1 = Console.ReadLine();
            nombre1 = Convert.ToInt32(saisie1);

            Console.WriteLine("Entrez le nombre2: ");
            saisie2 = Console.ReadLine();
            nombre2 = Convert.ToInt32(saisie2);

            resultat = nombre1 / nombre2;
            Console.WriteLine("Le résultat est :" + resultat);
            Console.ReadLine();
        }
    }

}