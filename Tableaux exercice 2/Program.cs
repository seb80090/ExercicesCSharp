using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_exercice_2
{
    class Program
    {
        static void Main();
        
        Console.WriteLine("***Tableaux exercice 2 v1.0 *** 23/08/2016");

        {
            

        }
        //fonction GetInteger pour lire un entier au clavier,        
        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int nombre = Int32.Parse(Console.ReadLine());
            return nombre;

        }

            //une fonction InitTab pour créer et initialiser l’instance de tableau 
            static void InitTab()
        {


            int[] tab = new int[10];

            //une fonction InitTab pour créer et initialiser l’instance de tableau de type entier : le nombre de postes souhaité sera entré au clavier

            Console.WriteLine("Entrez la taille du tableau");
            int taille = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < taille; i++)

                return taille;
            {
                Console.WriteLine("Entrez un nombre");
                tab[i] = Int32.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < taille; i++)
            {
                Console.Write(tab[i] + " ");          
            }

            //une fonction AfficheTab pour afficher tous les postes du tableau,

            static void AfficheTab();

            AfficheTab =Console.WriteLine( );


            Console.WriteLine("Appuyez sur une touche pour terminer");
            Console.ReadLine();
           }
        
    }
}

