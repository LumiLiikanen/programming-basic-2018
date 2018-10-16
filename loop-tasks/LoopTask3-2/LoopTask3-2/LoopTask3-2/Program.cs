using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötetyn luvun ja sitä peinempien positiivisten kokonaislukujen summan!");
            int number = 0;
            int i = 1;
            int fact = 0;

            do
            {
                Console.WriteLine("Syötä luku!");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                // number = int.Parse(Console.Readline());

                if (number <= 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }
            } while (number <= 0);

            while (i <= number)
            {
                fact = fact + i; //fact+i
                i = i + 1; //i+1
            }
            Console.WriteLine($"Tulos= {fact}!");

        }
    }
}
