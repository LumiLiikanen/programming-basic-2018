using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo kaksiulotteiseen kokonaislukutaulukkoon luvut väliltä 0-99!");
            int[,] numbers = new int[10,20];
            fun(ref numbers);
        }
        static void fun(ref int[,] numbers)
        {
            Random rand = new Random();
            for (int r = 0; r < numbers.GetUpperBound(0)+1; r++)
            {
                for (int c = 0; c < numbers.GetUpperBound(1)+1; c++)
                {
                    numbers[r, c] = rand.Next(100);
                    Console.WriteLine($"[{r:d2} , {c:d2}]: {numbers[r, c]}");
                }
            }
        }
    }
}
