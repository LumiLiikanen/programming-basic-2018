using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Ohjlema tulostaa vakioveikkauksen rivin");

            for (int j = 1; j <= 13; j++)
            {
                double number = rnd.NextDouble();
           
                if (number >= 0 && number <= 0.4)
                {
                    Console.WriteLine($"{j}. 1");
                }
                else if (number > 0.4 && number <= 0.6)
                {
                    Console.WriteLine($"{j}. X");
                }
                else
                {
                    Console.WriteLine($"{j}. 2");
                }
            }
        }

    }
}
