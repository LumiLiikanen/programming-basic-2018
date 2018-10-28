using System;

namespace LoopTask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa nopan heiton tuloksen 1000 kertaa ja laskee kuinka monta 6:sta heitettiin!");
            Random rnd = new Random();
            int number = 1;
            for (int i = 1; i <= 1000 ; i++)
            {
                Console.Write($"{i}: ");

                        number = rnd.Next(1,7);
                        Console.WriteLine($"{number}");
            }
            Console.WriteLine($"Numero 6 heitettiin {} kertaa");
        }
    }
}
