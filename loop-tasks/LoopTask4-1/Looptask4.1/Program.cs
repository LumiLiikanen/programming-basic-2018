using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
                int rndNumber;
            //rnd.NextDouble();


                 Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret!");
            for (int i = 0; i < 10; i++)
            {
                rndNumber = rnd.Next(2,100);
                Console.WriteLine($"{i+1}. {rndNumber} {Math.Sqrt(rndNumber)}");
            }
            {

            }
        }
    }
}
;