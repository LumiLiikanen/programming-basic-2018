using System;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa e -kirjaimet @ -merkeiksi!");
            Console.WriteLine("Syötä lause!");
            string userInput = Console.ReadLine();
            string temp = userInput.Replace('e', '@');
            Console.WriteLine($"Syötetty lause: {userInput}\nKorvattu lause: {temp}");
        }
    }
}
