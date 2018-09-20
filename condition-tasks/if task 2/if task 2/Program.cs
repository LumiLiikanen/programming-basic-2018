using System;

namespace if_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma selvittää onko luku pariton vai parillinen");
            Console.Write("syötä numero: ");
            String userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number % 2 == 0)
                Console.WriteLine($"luku {number} on parillinen");
            else
                Console.WriteLine($"luku {number} on pariton");


        }
    }
}
