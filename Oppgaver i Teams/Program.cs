using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgaver_i_Teams
{
    internal class Program
    {

        //Oppgave 1
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn navnet ditt:");

            Console.ReadLine();

            Console.WriteLine("Hyggelig å hilse på deg ");

            Console.ReadLine();

            // Oppgave 2

            int tall = 67;
            if (tall > 0)
                Console.WriteLine("Tallet er positivt");
            else if (tall < 0)
                Console.WriteLine("Tallet er negativt");
            else 
                Console.WriteLine("Tallet er 0");
            Console.ReadLine();


            // Oppgave 3

            {


            int[] tallArr = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < tallArr.Length; i++)
                {
                    Console.WriteLine(tallArr[i]);
                }
                Console.ReadLine();

            }

            // Oppgave 4
            string[] navn = new string[3];
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Tast navn");
                navn[i] = Console.ReadLine();
            }



            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(navn[i]);                
            }

            Console.ReadLine();

        }
        

    }
}
