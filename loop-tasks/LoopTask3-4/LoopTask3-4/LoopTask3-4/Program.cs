using System;

namespace LoopTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee positiivista syötettyä lukua pienempien lukujen summan ja negatiivista syötettyä lukua suurempien lukujen summan nollaan asti! ");
            int number = 0;
            int i = 0;
            int fact = 0;

            do
            {
                Console.WriteLine("Syötä numero!");
                String userinput = Console.ReadLine();
                number = int.Parse(userinput);

                if (number == 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }

            } while (number == 0);

            while (i != number) 
            {
                if (number > 0) 
                {
                    i = i + 1;
                    fact = fact + i;
                }

                else
                {
                    i = i - 1;
                    fact = fact + i;
                }
            }

            Console.WriteLine($"Tulos = {fact}");
        }
    }
}
