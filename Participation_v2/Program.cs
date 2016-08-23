using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_v2
{
    class Program
    {
        static void Main(string[] args) { 

            Console.WriteLine("***Participation v2*** 19/08/2016");

            //déclaration des variables
        string sit;
        int enf;
        int sal;
        int part=0;
        int montpart;
        

              //Entrée des données
        Console.WriteLine("Veuillez entrez votre situation maritale");
        Console.WriteLine("c pour célibataire, m pour marié(e)");
        sit=Console.ReadLine();
                
         Console.WriteLine("Veuillez entrez le nombre d'enfants ");
         enf=Int32.Parse(Console.ReadLine());
    
         Console.WriteLine("Entrez votre salaire");       
         sal=Int32.Parse(Console.ReadLine());
  
            
            
            if (sit=="c")
            {
                        part=20;
            }
            else
            {
                        part=25;
            }

            part=(enf*10)+part;

            if (sal < 1200)

            {
                        part = (enf * 10) + part;
            }   
            if (part>50)
            {
                         part = 50;
            }

            montpart = (sal*part)/100;

            Console.WriteLine("le taux de participation est de "+part);
            Console.WriteLine("le montant en euros de de participation sera de "+montpart);
            Console.ReadLine();


        }
    }
}
