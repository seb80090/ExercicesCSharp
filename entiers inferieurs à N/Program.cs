using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_entiers_inferieurs_a_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** les entiers inferieurs à N (V1.0, 17/08/16) ****");
            //déclaration de variables 
            int N;
            int i = 1;

            Console.WriteLine("entrez un nombre");
            N = Int32.Parse(Console.ReadLine());

            while (i <= N)
            {
                Console.WriteLine(i);
                i++;
            }


            Console.ReadLine();
        }

    }
}
