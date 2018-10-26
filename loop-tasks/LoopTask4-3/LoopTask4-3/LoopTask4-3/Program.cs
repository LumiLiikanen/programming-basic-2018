using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohljelma tulostaa satunnaisesti 20 kokonaislukua väliltä 0-50");

            Random rnd = new Random();
            int number = 1;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"rivi {i}: ");
                for (int j = 1; j <= 5; j++)
                {
                    number = rnd.Next(0, 51);
                    if (j == 5)
                        Console.WriteLine($"{number}");
                    else
                        Console.Write($"{number}, ");
                }

            }
        }
        
    }
}
