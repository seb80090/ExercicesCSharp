using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somme_d_un_intervalle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** somme d'un intervalle (V1.0, 17/08/16) ****");
            //déclaration de variables 
            int nombre1;
            int nombre2;
            int somme = 0;
            int i = 0;


            Console.WriteLine("Entrez un nombre");
            nombre1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entrez un second nombre");
            nombre2 = Int32.Parse(Console.ReadLine());

            if (nombre1 > nombre2)
            {
                Console.WriteLine("erreur, le nombre 2 doit être supérieur au nombre1");
                Console.ReadLine();

            }
            for (i = nombre1; i <= nombre2; i = i + 1)
            { somme = somme + i; }


            Console.WriteLine("la somme des entiers entre le nombre1 et nombre2 est :" + somme);
            Console.ReadLine();



        }
    }
}
