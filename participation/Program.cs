using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** participation (V1.0, 18/08/16) ****");
            //Variables
            string celibataire, marie;
            int enfants, salaire, participation = 0;

            //Entrée des données
            Console.WriteLine("Etes vous célibataire ? (oui / non)");
            celibataire = Console.ReadLine();
            Console.WriteLine("etes vous marié ? oui / non");
            marie = Console.ReadLine();
            Console.WriteLine("Combien avez vous d'enfants ?");
            enfants = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Indiquez votre salaire");
            salaire = Int32.Parse(Console.ReadLine());

            //calcul
            if (celibataire == "oui")
            {
                participation = 20;
            }
            if (marie == "oui")
            {
                participation = 25;
            }
            participation = (enfants * 10) + participation;
            if (salaire < 1200)
            {
                participation += 10; //participation = participation + 10
            }
            if (participation > 50)
            {
                participation = 50;
            }
            Console.WriteLine("la taux de participation est de : " + participation + "%");
            Console.ReadLine();
        }
    }
}
