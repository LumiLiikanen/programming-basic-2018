using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää lukuja kunnes käyttäjä syöttää luvun -1, ja laskee niiden summan!");
            int number;

            do
            {
                Console.WriteLine("Syötä luku!");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
            } while (number != -1);

            Console.WriteLine($"{}");
        }
    }
}
