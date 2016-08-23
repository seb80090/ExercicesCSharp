using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocr_listes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> jours = new List<string>();
            jours.Add("Lundi");
            jours.Add("Mardi");
            jours.Add("Mercredi");
            jours.Add("Jeudi");
            jours.Add("Vendredi");
            jours.Add("Samedi");
            jours.Add("Dimanche");

            //int indice = jours.IndexOf("Mercredi"); // indice vaut 2



            //ou peux s'écrire plus simplement:

            //List<string> jours = new List<string> { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };


            foreach (string semaine in jours)
            {
                Console.WriteLine(semaine);
            }
            

            Console.ReadLine();
        }

    }
}


