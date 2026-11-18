using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Opdracht_2
    {
        public void Run()
        {
            Console.WriteLine("Ik wordt wakker in mijn huis, wat ga ik doen?");

            int Keuze = int.Parse(Console.ReadLine());
            if (Keuze == 1)
            {

                Console.WriteLine("Ik zit te eten!");


            }
            else if (Keuze == 2)
            {

                Console.WriteLine("Je eet iets over de datum, maar je wordt niet ziek, dus je wint!");

            }
            else if (Keuze == 3)
            {
                Console.WriteLine("Je eet iets over de datum, maar je wordt wel ziek, dus je wint niet!");
            }
        }
    }
}
