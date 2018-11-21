using System;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötetystä lauseesta l -kirjainten määrän!");
            Console.WriteLine("Syötä lause!");
            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();
            int LetterCounter = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i].ToString() == "L")
                    LetterCounter++;
            }
            Console.WriteLine($"L -kirjaimien määrä {LetterCounter}");
        }
    }
}
