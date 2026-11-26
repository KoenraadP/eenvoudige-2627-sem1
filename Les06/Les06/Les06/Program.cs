using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Les06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hallo daar!");

            //Console.WriteLine("Typ je naam in:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Goedemorgen " + name);

            //Console.WriteLine("Wat is de score:");
            //double score = Convert.ToDouble(Console.ReadLine());

            // als de score groter dan of gelijk aan 50 is
            // dan tonen we de tekst "geslaagd"
            // anders tonen we de tekst "niet geslaagd"
            //if (score >= 50) 
            //{
            //    Console.WriteLine("geslaagd");
            //}
            //else
            //{
            //    Console.WriteLine("niet geslaagd");
            //}

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hoe oud ben je");
            int age = Convert.ToInt32(Console.ReadLine());

            // prijs voor ticket op basis van leeftijd
            // jonger dan 3: gratis
            // vanaf 3 tot en met 11: 5 euro
            // vanaf 12 tot en met 17: 8 euro
            // vanaf 18 tot en met 64: 12 euro
            // ouder dan 64: 6 euro

            decimal price;

            /*if (age < 3) price = 0;
            else if (age < 12) price = 5;
            ...*/

            if (age < 3)
            {
                price = 0;
            }
            else if (age < 12)
            {
                price = 5;
            }
            else if (age < 18)
            {
                price = 8;
            }
            else if (age < 65)
            {
                price = 12;
            }
            else
            {
                price = 6;
            }

            Console.WriteLine("De prijs voor jouw ticket is €"
                                + price + ".");

            Console.WriteLine("Ben je een student? Typ ja of nee");
            string inputStudent = Console.ReadLine();

            bool isStudent = false;
            if (inputStudent == "ja") isStudent = true;

            // als de leeftijd groter is dan 64 
            // OF je bent student
            // dan krijg je korting (zin "Je krijgt korting!" plaatsen)
            // anders plaats je "Geen korting."

            if (age > 64 || isStudent)
            {
                Console.WriteLine("Je krijgt korting!");
            }
            else
            {
                Console.WriteLine("Geen korting.");
            }

            /*if (age < 65 && !isStudent)
            {
                Console.WriteLine("Geen korting.");
            }
            else
            {
                Console.WriteLine("Je krijgt korting!");
            }*/
        }
    }
}
