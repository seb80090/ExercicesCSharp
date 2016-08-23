using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoyennePonderee
{
    class conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Moyenne pondérée des notes (V1.0, 16/08/16) ****");
            String saisie1;
            String saisie2;
            String saisie3;

            Double note1;
            Double note2;
            Double note3;
            Double moyenne;

            Console.WriteLine("entrez une prémière note ");
            saisie1 = Console.ReadLine();
            note1 = Convert.ToInt32(saisie1);

            Console.WriteLine("entrez la seconde note ");
            saisie2 = Console.ReadLine();
            note2 = Convert.ToInt32(saisie2);

            Console.WriteLine("entrez la troisième note ");
            saisie3 = Console.ReadLine();
            note3 = Convert.ToInt32(saisie3);


            moyenne = ((note1*3) + (note2*2) + (note3))/6;

            Console.WriteLine("La moyenne pondérée est de :" + moyenne);
            Console.ReadLine();
            
        }
    }


}