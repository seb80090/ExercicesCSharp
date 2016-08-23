
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parite
{
    class Program
    {


        static void Main()
        {
            Console.Write("**** parite (V1.0, 18/08/16) ****");

            double nombre;
            string saisie;

            Console.WriteLine("Entrez un nombre: ");
            saisie = Console.ReadLine();
            nombre = Convert.ToDouble(saisie);
            //nombre = Double.Parse(Console.ReadLine());


            if (nombre % 2 == 0)
            {
                Console.WriteLine("le nombre est pair");
            }
            else
            {
                Console.WriteLine("le nombre est impair");
            }
            Console.ReadLine();

        }
    }

}
