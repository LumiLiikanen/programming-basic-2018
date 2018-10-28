using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa annetun lauseen viisi kertaa!");
            Console.WriteLine("Kirjoita lause!");
            string userInput = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
                Console.WriteLine($"{i}. {userInput}");

        }
    }
}
