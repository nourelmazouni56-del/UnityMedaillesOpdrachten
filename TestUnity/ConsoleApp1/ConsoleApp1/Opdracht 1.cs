using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Opdracht_1
    {
        public void Run()
        {
            Console.WriteLine("Hallo wat is je naam?");
            string Naam = Console.ReadLine();

            Console.WriteLine("Wat is jouw leeftijd?");
            int leeftijd = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hallo {Naam}, jij bent {leeftijd} jaar oud!");
        }
    }
}
