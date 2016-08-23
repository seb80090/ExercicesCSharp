using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Nombre Magique v1.0*** 22/08/2016");
            //déclaration des variables
            int nombre = 0;
            Random rnd = new Random();
            int magic = rnd.Next(1, 101);

            while (nombre != magic)
            {
                Console.WriteLine("Entrez un nombre");
                nombre = Int32.Parse(Console.ReadLine());

                if (nombre < magic)
                {
                    Console.WriteLine("plus grand");
                }
                if (nombre > magic)
                {
                    Console.WriteLine("Plus petit");
                }
            }

            Console.WriteLine("Bravo");


        }
    }
}
