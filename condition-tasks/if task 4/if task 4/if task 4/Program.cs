using System;

namespace if_task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee numerot nousevaan järjestykseen!");
            Console.WriteLine("Syötä ensimmäinen luku: ");
            String userInput = Console.ReadLine();
            int x = int.Parse(userInput);
            Console.WriteLine("Syötä toinen luku: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);
            Console.WriteLine("Syötä kolmas luku: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            Console.WriteLine($"Syötit luvut {x} - {y} - {z}");

            if (x > y && y > z)
                    Console.WriteLine($"{z} - {y} - {x}");

                   else if (x > y && y < z && z < x)
                Console.WriteLine($"{y} - {z} - {x}");
            
            else if (x > y && y < z && z > x)
                Console.WriteLine($"{y} - {x} - {z}");

                if (x < y && x > z && z < y)
                Console.WriteLine($"{z} - {x} - {y}");

                else if (x < y && x < z && y < z)
                Console.WriteLine($"{x} - {y} - {z}");

                    else if (x < y && x < z && y > z)
                Console.WriteLine($"{x} - {z} - {y}");

        }
    }
}
