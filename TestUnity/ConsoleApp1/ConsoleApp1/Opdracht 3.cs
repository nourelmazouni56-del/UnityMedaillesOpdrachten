using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Opdracht_3
    {
        public void Run()
        { }
            class Program
        {
            static void Main()
            {
                Console.Write("Wat is de temperatuur in graden Celsius? ");
                int temperatuur = Convert.ToInt32(Console.ReadLine());

                if (temperatuur < 0)
                {
                    Console.WriteLine("Tip: Trek een dikke winterjas, handschoenen en een sjaal aan.");
                }
                else if (temperatuur < 10)
                {
                    Console.WriteLine("Tip: Doe een warme jas aan.");
                }
                else if (temperatuur < 20)
                {
                    Console.WriteLine("Tip: Een vest of lichte jas is voldoende.");
                }
                else if (temperatuur < 30)
                {
                    Console.WriteLine("Tip: Perfect weer voor lichte kleding. Vergeet niet genoeg water te drinken.");
                }
                else
                {
                    Console.WriteLine("Tip: Het is erg warm. Draag luchtige kleding, drink veel water en zoek schaduw op.");
                }

                Console.WriteLine("\nDruk op een toets om af te sluiten...");
                Console.ReadKey();

            }
        }
    }
}







            
        
    
    

