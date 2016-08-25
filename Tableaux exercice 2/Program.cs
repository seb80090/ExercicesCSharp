using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux_exercice_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Tableaux exercice 2 v1.0 *** 23/08/2016");

            int[] tableau = InitTab(); //permet de créer un tableau de la taille souhaitée
            tableau = SaisieTab(tableau);//permet de remplir toutes cases du tableau 
            int choix;
            
            do
            {
                Console.Clear();
                Console.WriteLine("1 - tous les postes du tableau");
                Console.WriteLine("2 - index");
                Console.WriteLine("3 - maximum de la moyenne");
                choix = GetInteger("Entrez votre choix, 0 pour quitter");

                switch (choix)
                {
                    case 1:
                        Console.WriteLine();
                        AfficheTab(tableau);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        RechercheTab(tableau);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        InfoTab(tableau);
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (choix != 0);
        }


        //fonction GetInteger pour lire un entier au clavier,        
        static int GetInteger(string message)
        {
            Console.WriteLine(message);
            int nombre = Int32.Parse(Console.ReadLine());
            return nombre;

        }

        //une fonction InitTab pour créer et initialiser l’instance de tableau 
        static int[] InitTab()
        {
            //une fonction InitTab pour créer et initialiser l’instance de tableau de type entier : le nombre de postes souhaité sera entré au clavier            
            int taille = GetInteger("Entrez la taille du tableau");
            int[]tab = new int[taille];
            return tab;
        }
        //une fonction AfficheTab pour afficher tous les postes du tableau,

        static int[] SaisieTab(int[] saisie)
        {
            for (int i = 0; i < saisie.Length; i++)
            {
                saisie[i] = GetInteger("Entrez le nombre " + (i + 1));
            }
            return saisie;
        }

        static void AfficheTab(int[] affiche)
        {
            foreach (int poste in affiche) // permet d'afficher les postes du tableau
            {
                Console.WriteLine(poste);
            }
        }

        static void RechercheTab(int[] recherche)
        {
            int nombre = GetInteger("Entrez la case du tableau recherchée :");
            Console.WriteLine(recherche[nombre]);
        }

        static void InfoTab(int[] info )
        {
            int max = info[0];
            double moyenne = 0, somme = 0;

            for (int i = 0; i < info.Length; i++)
            {

                //Comparaison du max avec la case 'i'
                if (max < info[i])
                {
                    max = info[i];
                }
                //Fin du IF

                //Calcul la somme des valeurs du tableau
                somme = info[i] + somme;                
            }

            moyenne = somme / info.Length;


            Console.WriteLine("Le maximum du tableau est de : " + max+ "\nLa moyenne du tableau est de : " + moyenne);// le \n permet de retourner à la ligne
            
        }

    }
}