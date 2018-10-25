using System;

namespace Looptask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötettyä lukua pienempien parillisten ja parittomien lukujen summat erikseen nollaan asti!");
            int number = 0;
            int i = 0;
            int evensum = 0;
            int oddsum = 0;

            do
            {
                Console.WriteLine("Syötä luku!");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

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
                }
                else
                {
                    i = i - 1;
                }

                if ( i % 2 == 0)
                {
                    evensum = evensum + i;
                }
                else
                {
                    oddsum = oddsum + i;
                }
            }

            Console.WriteLine($"Parillisten summa = {evensum} ja parittomien summa = {oddsum}!");
        }
    }
}
