using System;

namespace Looptask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee luvun kertoman!");
            int number = 0;
            int i = 1;
            int fact = 1;
            do
            {
                Console.WriteLine("syötä luku!");
                String userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(console.ReadLine());

                if (number <= 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }

            } while (number <= 0);

            while (i <= number)
            {
                fact = fact * i; //fact*i
                i = i + 1; //i+1
            }
            Console.WriteLine($"Luvun {number}! = {fact}");





        }
    }
}
