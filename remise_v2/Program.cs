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
            Console.WriteLine("**** remise (V2.0, 18/08/16) ****");

            //déclaration des variables
            double pu;
            double qtecom;
            double port = 0;
            double rem = 0;
            double total;
            double pap = 0;
            Console.WriteLine("entrez le prix unitaire du produit");
            pu = Double.Parse(Console.ReadLine());

            Console.WriteLine("entrez la quantité commandée");
            qtecom = Double.Parse(Console.ReadLine());

            total = qtecom * pu;

            if (total >= 500)
            {

                port = 0;
            }

            else
            {
                port = total * 0.02;
            }

            if (port > 0 & port < 6)

            {
                port = 6;
            }


            if (total >= 100 & total <= 200)
            {
                rem = total * 0.05;
            }

            else if (total > 200)
            {
                rem = total * 0.10;
            }
           

            pap = total - rem + port;

            Console.WriteLine("Le prix a payer est de " + pap);
            Console.ReadLine();

        }
     }
 }







