using System;

namespace if_task_lipun_hinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee lipun hinnan!");
            int ticketPrise = 16;
            double discount1 = 1.0;
            double discount2 = 0.5;
            double discount3 = 0.45 * 0.15;
            double discount4 = 0.15;
            double discount5 =
            
            Console.WriteLine("Oletko < 7 vai 7-65 vai >65 -vuotias?");
            string userInput = Console.ReadLine();
            if (userInput == "< 7")
                Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount1}€");
            else if > 65
                Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount2}€");
            else if 7 - 65
                Console.WriteLine("Oletko opiskelija kylla/ei?");
            string userInput = Console.ReadLine();
            { if kylla
                Console.WriteLine("Oletko myös MTK:n jäsen kylla/ei?);
                    String userInput = Console.ReadLine();
                if kylla
                    Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount3}€");
                else if ei
                    Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount4}€");
            }
            if ei
                Console.WriteLine("Oletko Varusmies?");
            String userInput = Console.ReadLine();
            if kylla
                Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount2}€");
            else if ei
                Console.WriteLine("Oletko MTK:n jäsen?");
            String userInput = Console.ReadLine();
            if kylla
                Console.WriteLine($"Lipunhintasi on {ticketPrise - ticketPrise * discount4}€");
            else if ei
                Console.WriteLine($"Lipunhintasi on {ticketPrise}€")
        }
    }
}
