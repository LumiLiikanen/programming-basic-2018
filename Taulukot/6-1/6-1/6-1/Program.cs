using System;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hinnasto!");
            double[] ProductPrice = new double[] { 7.96, 72.0, 99.90 };
            int[] ProductAmount = new int[] { 1, 3, 2 };
            double[] ProductTotalPrice = new double[3];

            for (int i = 0; i < ProductTotalPrice.Length; i++)
            {
                ProductTotalPrice[i] = ProductAmount[i] * ProductPrice[i];
                Console.WriteLine($"tuote {i+1}. {ProductTotalPrice[i]:c}");
            }
        }
    }
}
