﻿using System;

namespace if_task_lipun_hinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee lipun hinnan!");
            int TicketPrise = 16;
            double discount = 0;

            Console.WriteLine("Oletko varusmies? k tai e ");
            string userInput = Console.ReadLine();
            if (userInput == "k")
                discount = 0.50;

            else
            {
                Console.WriteLine("Oletko opiskelija? k tai e ");
                userInput = Console.ReadLine();
                if (userInput == "k")
                {
                    Console.WriteLine("Oletko MTK:n jäsen? k tai e ");
                    userInput = Console.ReadLine();
                    if (userInput == "k")
                        discount = 0.60;
                    else
                        discount = 0.45;
                }
                else
                {
                    Console.WriteLine("Syötä ikä: ");
                    String userInput1 = Console.ReadLine();
                    int age = 0;
                    age = int.Parse(userInput1);

                    if (age < 7)
                    {
                        discount = 1.0;
                    }
                    else if (age >= 7 && age <= 15 || age > 65) 
                    {
                        discount = 0.50;
                    }

                    else
                    {
                        Console.WriteLine("Oletko MTK:n jäsen? k tai e ");
                        userInput = Console.ReadLine();
                        if (userInput == "k")
                        {
                            discount = 0.15;
                        }
                    }
                }
            }
            Console.WriteLine($"Lipun hinta on {TicketPrise - TicketPrise * discount}");

        }
    }
}
