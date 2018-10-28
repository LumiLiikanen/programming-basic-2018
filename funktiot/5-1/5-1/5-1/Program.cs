using System;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma antaa yhtä monta tähteä kuin käyttäjän syöttämä luku!");
            int n;
            while (true)
            {
                Console.WriteLine("Tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Luku 0 ei ole sallittu luku!");
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
        }
        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for(int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}
