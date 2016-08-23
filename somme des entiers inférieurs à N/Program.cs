using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_somme_des_entiers_inferieurs_a_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** la somme des entiers inferieurs à N (V1.0, 17/08/16) ****");
            //déclaration de variables 
            int N;
            int i = 1;
            int somme = 0;

            Console.WriteLine("entrez un nombre");
            N = Int32.Parse(Console.ReadLine());

            while (i < N)
            {
                somme = somme + i;



                i++;
            }
            Console.WriteLine("la somme des entiers inférieurs au chiffre entré dans le système est :" + somme);
            Console.ReadLine();
        }
    }

}