using System;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Ohjelma pyytää käyttäjältä väliltä 1-10 ja palauttaa sallitun luvun!");
                int number = numberFromRange(1, 10);
                Console.WriteLine($"Luku {number} on sallittu!");
            }
        
            int numberFromRange(int lowerbound, int upperbound)
            {
                int allowedNumber;
                while (true)
                {
                    Console.WriteLine("Syötä luku!");
                    bool isnumber = int.TryParse(Console.ReadLine(), out int userInput);

                    if (userInput >= lowerbound && userInput <= upperbound)
                    {
                        allowedNumber = userInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Luku ei ole sallittu");
                    }

                }
                return allowedNumber;
            }
        }
    }
}
