using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        { 
          Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret!");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}. {Math.Sqrt(i + 1)}");
            }
        }
    }
}
;