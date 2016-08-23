using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        { 
            System.Console.WriteLine("*** Console (V1.0, 16/08/16) ****");
            //Déclaration des variables
            double nombre;
            string saisie;
            char conversion;

            //Entrée des données
            System.Console.WriteLine("Entrez un nombre");
            saisie = System.Console.ReadLine();

            //Conversion en double
            nombre = Convert.ToDouble(saisie);

            //Convertion d'un nombre en caractère Unicode
            conversion = (char)nombre;

            System.Console.WriteLine("Le nombre " + nombre + " équivaut à " + conversion + ".");
            System.Console.ReadLine();
                   
        }
    }
}
