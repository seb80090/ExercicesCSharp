using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jours = new string[7] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Venderdi", "Samedi", "Dimanche" };//déclaration du tableau
            Array.Sort(jours);// permet de trier par ordre alphabétique les éléments du tableau

            for (int i = 0; i < jours.Length; i++) //boucle qui permet d'afficher les valeurs i
            {
                Console.WriteLine(jours[i]); //affiche les valeurs i (jours) du tableau
            }

            Console.ReadLine();




        }

    }
}