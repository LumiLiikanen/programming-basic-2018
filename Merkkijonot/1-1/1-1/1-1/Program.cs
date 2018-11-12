using System;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötettyjen merkkien määrän!");
            Console.WriteLine("Syötä lause!");
            string userInput = Console.ReadLine();
            int k = userInput.Length;

                Console.WriteLine($"Lauseessa on: {k} merkkiä!");
        }
    }
}
