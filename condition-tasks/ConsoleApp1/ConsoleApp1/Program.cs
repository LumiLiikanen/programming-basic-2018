using System;

namespace IfTask1
{//this one line komment
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko annettu luku positiivinen, negatiivinen vai nolla");
            Console.Write("syötä numero: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"numero {number} on negatiivinen!");
            else
                Console.WriteLine($"numero {number} on positiivinen!");
                Console.WriteLine($"syötit numeron {userInput}");
        }
    }
}
