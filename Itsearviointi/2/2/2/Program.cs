using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa annetun lauseen yhtä monta kertaa kun siinä on kirjaimia!");
            Console.WriteLine("Kirjoita lause!");
            string userInput = Console.ReadLine();

            int k = userInput.Length;

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
