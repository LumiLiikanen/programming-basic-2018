using System;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                int maxIndex = 0;
                Console.WriteLine("Ohjelma pyytää 10 lukua ja palauttaa niistä suurimman!");
                Console.WriteLine($"Suurin luku oli {Numbers(ref maxIndex)} ja se oli {maxIndex}.");
                Console.ReadKey();
            }
            int Numbers(ref int maxIndex)
            {
                int nbr = 0;
                int maxNbr = 0;

                bool isNumber;
                string output = "";
                Console.WriteLine("Syötä 10 positiivista kokonaislukua!");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{i + 1}. ");
                    isNumber = int.TryParse(Console.ReadLine(), out nbr);
                    if (isNumber && nbr > 0)
                    {
                        output += $"{nbr} ";
                        if (maxNbr < nbr)
                        {
                            maxNbr = nbr;
                            maxIndex = i + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Väärä syöte, syötä positiivinen kokonaisluku!");
                        i--;
                    }
                }
                Console.WriteLine($"Syötit seuraavat luvut:\n{output}\n");
                return maxNbr;
            }
        }

    }
}