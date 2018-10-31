using System;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua väliltä 1-50 ja talukoi ne sekä ilmoittaa keskiarvon!");
            double [] it = new double [100];
            double sum = 0;
            double average = 0;
            Random rnd = new Random();

            for (int i = 0; i < it.Length; i++)
            {
                it[i] = rnd.Next(51);
            }

           for (int i = 0; i< it.Length; i++)
            {
                sum = sum + it[i];
            }

                average = sum / 100;

            for (int i = 0; i < it.Length; i++)
            {
                Console.WriteLine($"{i+1}. {it[i]}");
            }
            Console.WriteLine($"Keskiarvo: {average}");
        }
    }
}
