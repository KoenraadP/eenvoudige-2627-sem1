using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maak een keuze:");
            Console.WriteLine("1, 2 of 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            string output;

            switch (choice)
            {
                case 1:
                    output = "Optie 1 gekozen: nieuwe klant";
                    break;
                case 2:
                    output = "Optie 2 gekozen: bestelling bekijken";
                    break;
                case 3:
                    output = "Optie 3 gekozen: afsluiten";
                    break;
                default:
                    output = "Ongeldige keuze";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
