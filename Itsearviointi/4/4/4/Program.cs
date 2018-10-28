using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma pyytää kaksi lukua ja laskee näiden summan, erotuksen, tulon ja osamäärän");

            Console.WriteLine("Syötä luku!");
            string userInput = Console.ReadLine();
            double number;
            number =double.Parse(userInput);

            Console.WriteLine("Syötä luku!");
            string userInput1 = Console.ReadLine();        
            double number1;
            number1 = double.Parse(userInput1);

            Console.WriteLine($"{number} + {number1} = {number + number1}");
            Console.WriteLine($"{number} - {number1} = {number - number1}");
            Console.WriteLine($"{number} x {number1} = {number * number1}");
            Console.WriteLine($"{number} / {number1} = {number % number1}");
        }
    }
}
