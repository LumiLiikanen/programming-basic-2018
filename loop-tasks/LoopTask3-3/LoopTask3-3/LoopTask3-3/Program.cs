using System;

namespace LoopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötettyä lukua pienempien parillisten ja parittomien positiivisten kokonaislukujen summat erikseen!");
            int number = 0;
            int i = 1;
            int oddsum = 0;
            int evensum = 0;

            do
            {
                Console.WriteLine("Syötä luku!");
                String userInput = Console.ReadLine();
                number = int.Parse(userInput);
                if (number <= 0)
                {
                    Console.WriteLine("Väärä syöte!");
                }

            } while (number <= 0);

            while (i <= number)
            {
                if (i % 2 == 0)
                {
                    evensum = evensum + i;
                    i = i + 1;
                }

                else 
                {
                    oddsum = oddsum + i;
                    i = i + 1;
                }
            } 

            Console.WriteLine($"Parillisten summa = {evensum} ja Parittomien summa = {oddsum}!");
        }
    }
}
