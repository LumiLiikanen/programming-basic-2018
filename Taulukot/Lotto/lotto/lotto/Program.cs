using System;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo lottonumerot!");
            int[] lottery = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                int rndnbr = rnd.Next(40);

                    if (lottery[rndnbr] == 0)
                    {
                        lottery[rndnbr] = 1;
                    }
                    else
                    {
                        i--;
                    }
            }

            while (true)
            {
                int rndnbr = rnd.Next(40);
                if (lottery[rndnbr] == 0)
                {
                    lottery[rndnbr] = 2;
                    break;
                }
            }
            Console.WriteLine("Arvottiin oikeat luvut");
            for (int i = 0; i < lottery.Length; i++)
                if (lottery[i] == 1)
                {
                    Console.Write($"{ i + 1} ");
                }

            for (int i = 0; i < lottery.Length; i++)
                if (lottery[i] == 2)
                {
                    Console.WriteLine($"\nLisänumero: { i + 1} ");
                }

            Console.WriteLine($"plusnumero: {rnd.Next(40) + 1}");
        }
    }
}
