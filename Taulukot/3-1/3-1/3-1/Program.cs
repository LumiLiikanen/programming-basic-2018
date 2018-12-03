using System;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo yksiulotteiseen taulukkoon luvut 0-19!");
            int[] numbers = new int[10];
            fun(ref numbers);
            Random rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(20);
            }
        }
        static void fun(ref int[] numbers)
        {
             Random rand = new Random(); 
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(20);
                Console.WriteLine($"[{i:d2}]: {numbers[i]}");
            }
        }
    }
}
