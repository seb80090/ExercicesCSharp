using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionDeTemperatures
{
    class conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversion De Temperatures (V1.0, 16/08/16) ****");
            String saisie1;

            Double F;

            Double C;

            Console.WriteLine("entrez la temperature en degres Fahrenheit ");
            saisie1 = Console.ReadLine();
            F = Convert.ToInt32(saisie1);



            C = C = (5.0 / 9.0) * (F - 32);
            Console.WriteLine("Le résultat en Celsius :" + C);
            Console.ReadLine();

        }
    }


}