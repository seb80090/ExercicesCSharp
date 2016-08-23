using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** remise (V1.0, 17/08/16) ****");

            //Variables
            double PU, QTECOM, PAP, PORT, REM = 0, TOTAL;

            //Entrée des données
            Console.WriteLine("Entrez le prix unitaire");
            PU = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez la quantité");
            QTECOM = Double.Parse(Console.ReadLine());

            //calcul
            TOTAL = PU * QTECOM;

            if (TOTAL >= 500)
            {
                PORT = 0;
            }
            else
            {
                PORT = TOTAL * 0.02;
            }

            if (PORT > 0 & PORT < 6)
            {
                PORT = 6;
            }

            if (TOTAL >= 100 & TOTAL <= 200)
            {
                REM = TOTAL * 0.05;
            }
            if (TOTAL > 200)
            {
                REM = TOTAL * 0.10;

            }
            PAP = TOTAL - REM + PORT;

            //Resultat
            Console.WriteLine("Le prix a payer est " + PAP);
            Console.ReadLine();


        }
    }
}
