using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program

         {
        
        static void Multiples()
        {

        }

        static void SommeEtMoyenne()
        {

        }
        static void Voyelles()
        {

        }
        static void RechercheDuNombreDeCaracteresSuivants()
        {

        }
        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int nombre = Int32.Parse(Console.ReadLine());
            return nombre;
        }

        static void Main(string[] args)
        {
            Console.Write("***Menu v1.0 *** 23/08/2016");
            Console.WriteLine("1 - Multiples");
            Console.WriteLine("2 - Somme et moyennes");
            Console.WriteLine("3 - Voyelles");
            Console.WriteLine("4 - Recherche du nombre des caracteres suivants");
            int choix = GetInteger("Entrez votre choix");
            switch (choix)
            {
                case 1:
                    Multiples();
                    break;
                case 2:
                    SommeEtMoyenne();
                    break;
                case 3:
                    Voyelles();
                    break;
                case 4:
                    RechercheDuNombreDeCaracteresSuivants();
                    break;
            }


        }
    }
}
