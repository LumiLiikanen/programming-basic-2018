using System;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo onko syötetty sana tai lause palintromi!");
            Console.WriteLine("Syötä sana tai lause!");
            string userInput = Console.ReadLine();
            String userInputtmp = userInput.ToUpper();
            userInputtmp = userInput.Replace(" ", "");

            for (int i = 0; i < userInputtmp.Length; i++)
            {
                if (userInputtmp[i] != userInputtmp[userInputtmp.Length - 1 - i])
                {
                    Console.WriteLine($"{userInput} ei ole palintromi");
                    break;
                }

                else
                {
                    Console.WriteLine($"{userInput} on palintromi!");
                    break;
                }
            }

        }
    }
}
