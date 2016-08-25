using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDuPendu
{
    class Program

    {

        static void Main(string[] args)
        {

            //déclaration des variables
            string saisie, lettre;
            //variable tableau
            string[] MotSecret; 
            string[] MotConstruit;


            // entrée des données 
            Console.WriteLine("Entrez un mot ");
            saisie = Console.ReadLine();

           
            //construction des tabeaux 
            MotSecret = new string[saisie.Length];
            MotConstruit = new string[saisie.Length];

            //boucle permettant de remplacer le nombre de caractères entré par l'utilisateur par des "_"
            for (int i = 0; i < saisie.Length; i++)
            {
                MotSecret[i]= saisie.Substring(i, 1);
                MotConstruit[i] = "_";
            }
            //boucle permettant de comparer les tableaux MotSecret et mot construit 
            while (MotSecret!=MotConstruit)
            {
                Console.WriteLine("\nEntrez une lettre");
                lettre = Console.ReadLine();

                for (int i = 0; i < saisie.Length; i++)
                {
                    if (MotSecret[i] == lettre)
                    {
                        MotConstruit[i] = lettre;
                    }
                }
                for (int i = 0; i < saisie.Length; i++)
                {
                    Console.Write(MotConstruit[i] + " ");
                    

                }  
                                          
            }
            
       

        }
    }
}
