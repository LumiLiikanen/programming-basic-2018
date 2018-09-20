using System;

namespace if_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma kertoo onko luku parillinen vai pariton ja onko se negatiivinen, positiivinen vai nolla");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"numero {number} on negatiivinen!");
            else if (number > 0)
                Console.WriteLine($"numero {number} on positiivinen!");
            Console.WriteLine($"syötit numeron {userInput}");

        }
    }
}
