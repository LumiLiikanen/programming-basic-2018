﻿using System;

namespace if_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjelma kertoo onko luku parillinen vai pariton ja onko se negatiivinen, positiivinen vai nolla");
            Console.Write("Syötä numero: ");
            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber)
            {
                if (number == 0)
                    Console.WriteLine($"luku {number} on nolla!");
                else if (number < 0)
                    Console.WriteLine($"luku {number} on negatiivinen!");
                else if (number > 0)
                    Console.WriteLine($"luku {number} on positiivinen!");

                if (number % 2 == 0)
                    Console.WriteLine($"luku {number} on parillinen!");
                else
                    Console.WriteLine($"luku {number} on pariton!");
            } 
            else
                Console.WriteLine("väärä syöte!");

        }
    }
}
