using System;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            intro(out x, out y); 
            Console.WriteLine(SmallerNumber(x,y));
        }

        static void intro(out int number1, out int number2)
        {
            Console.WriteLine("Ohjelma palauttaa kahdesta annetusta luvusta pienemmän!");
            Console.WriteLine("Syötä 1. luku!");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä 2. luku!");
            number2 = int.Parse(Console.ReadLine());
        }
        static string SmallerNumber(int a, int b)
        {
            if (a == b)
                return $"{a} on yhtäsuuri kuin {b}";
            else if (a < b)
                return $"{a} on pienempi kuin {b}";
            else
                return $"{b} on pienempi kuin {a}";
        }
    }
}
