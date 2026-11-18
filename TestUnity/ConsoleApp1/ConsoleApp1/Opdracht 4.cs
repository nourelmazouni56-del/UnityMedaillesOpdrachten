using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Opdracht_4
    {
        public void Run() { }
           

class Program
        {
            // Functie die controleert of iemand 18+ is
            static bool IsVolwassen(int leeftijd)
            {
                return leeftijd >= 18;
            }

            static void Main()
            {
                Console.Write("Voer je leeftijd in: ");
                int leeftijd = Convert.ToInt32(Console.ReadLine());

                bool volwassen = IsVolwassen(leeftijd);

                if (volwassen)
                {
                    Console.WriteLine("Je bent 18 jaar of ouder.");
                    Console.WriteLine("Je mag stemmen.");
                }
                else
                {
                    Console.WriteLine("Je bent jonger dan 18 jaar.");
                    Console.WriteLine("Je mag nog niet stemmen.");
                }

                Console.WriteLine("\nDruk op een toets om af te sluiten...");
                Console.ReadKey();
            }
        }

    }
}

