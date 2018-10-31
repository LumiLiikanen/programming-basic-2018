using System;

namespace esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma alustaa kokonaisluku taulukon (10alkiota), johon arvotaan lukuja väliltä 0-100");
            int[] numbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Ohjelman suoritus päättynyt");
        }
    }
}
