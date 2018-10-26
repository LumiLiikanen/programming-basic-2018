using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo monta kruunaa ja laavaa heitetään käyttäjän antamalla luvulla!");
 
                Console.WriteLine("Monta kertaa kolikkoa heitetään?");
                int number = int.Parse(Console.ReadLine());
                int heads = 0;
                int tails = 0;
                Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                int rndNumber = rnd.Next(2);
                if (rndNumber == 0)
                    tails++;
                else
                    heads++;
            }

            Console.WriteLine($"Kolikkoa heitettiin {number} kertaa!");
            Console.WriteLine($"Klaavoja tuli {tails} ja kuunoja {heads}");
        }
    }
}
