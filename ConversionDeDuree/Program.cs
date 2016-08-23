using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeDuree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** conversion de durée (V1.0, 16/08/16) ****");
            //déclaration des variables
            string saisie;
            int secs;
            int mins;
            int heures;
            int i;   
            Console.WriteLine ("Entrez la durée en secondes");
            saisie=Console.ReadLine();
            i = Convert.ToInt32(saisie);
            
            //calcul de l'heure et de secondes qui restent
            heures = (i/3600);
            secs = (i % 3600);
          
            //calcul des minutes et des secondes qui restent
            mins = secs/60;
            secs = secs%60;

            Console.WriteLine("heures = " + heures);
            Console.WriteLine("minutes = " + mins);
            Console.WriteLine("secondes = " + secs);
            Console.ReadLine();
        
        }
    }
} 

