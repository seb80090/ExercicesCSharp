using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    class Program
    {
        int nombre;


        static void Main()
        {
            int r;

            r = CompteLettre("il fait beau à Amiens", "i");

            Console.WriteLine("Le résultat = " + r);

        }

        static void TableDeMultiplication(int nombre)
        {
            Console.WriteLine("Table de multiplication de " + nombre);
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, nombre, i * nombre);
            }
        }

        static int Ajoute(int a, int b)
        {
            int resultat;

            resultat = a + b;

            return resultat;
        }

        static int SaisieNombre(string message)
        {
            Console.WriteLine(message);
            int nombre = Int32.Parse(Console.ReadLine());

            return nombre;
        }

        static int CompteLettre(string phrase, string lettre)
        {
            int compteur = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase.Substring(i, 1) == lettre)
                {
                    compteur++;
                }
            }

            return compteur;
        }


    }
}
