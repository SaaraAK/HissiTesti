using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voit lopettaa näppäimellä x ja painaa enteriä.");
             int ryhmä, täydetHissit, viimeisessä;
            string x;
            do              
       
           {
                Console.WriteLine("Anna ryhmän koko");
                ryhmä = int.Parse(Console.ReadLine());
        täydetHissit = ryhmä / 8; // kokonaisjako
                viimeisessä = ryhmä % 8; // jakojäännöslaskutoimistus, paljonko jää kokonaisjaosta yli
                Console.WriteLine("Täysiä hissejä {0}, viimiseen jää {1} henkilöä", täydetHissit, viimeisessä);
                x = Console.ReadLine();
                Console.WriteLine(x);
            
              
            } while (x != "x");
            
       

        }
    }
}
