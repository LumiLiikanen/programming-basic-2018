using System;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Ohjelma tarkastaa syötetyn viitenumeron!\n2. Ohjelma luo viitenumeron!\n3. Ohjelma luo hautun määrän viitenumeroita!");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        string RefNbr = ReferenceNumber();
                        string ReverseRefNbr = Reverse(RefNbr.Substring(0, RefNbr.Length - 1));
                        string CheckNbr = CheckMark(ReverseRefNbr);
                        if (CheckNbrChecker(RefNbr.Substring(RefNbr.Length - 1, 1), CheckNbr) == true)
                        {
                            Console.WriteLine($"{RefNbr} - OK");
                        }
                        else
                        {
                            Console.WriteLine($"Vitenumero on väärin!");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Kirjoita viitenumero ilman tarkistusnumroa!");
                        string RefNbrBase = Console.ReadLine();
                        string ReverseRefNbr = Reverse(RefNbrBase);
                        string CheckNbr = CheckMark(ReverseRefNbr);
                        string RefNbr = RefNbrBase + CheckNbr;
                        RefNbr = SpaceMaker(RefNbr);
                        Console.Clear();
                        Console.WriteLine($"Viitenumerosi on {RefNbr}");
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Kirjoita viitenumero ilman tarkistusnumroa!");
                        string RefNbrBase = Console.ReadLine();
                        int amount = Amount();
                        string[] RefNbrList = ListMaker(RefNbrBase, amount);
                        string [] CheckNbrList = new string[RefNbrList.Length];
                        for (int i = 0; i < RefNbrList.Length; i++)
                        {
                            CheckNbrList[i] = Reverse(RefNbrList[i]);
                        }
                        for (int i = 0; i < RefNbrList.Length; i++)
                        {
                            CheckNbrList[i] = CheckMark(CheckNbrList[i]);
                        }
                        for (int i = 0; i < RefNbrList.Length; i++)
                        {
                            RefNbrList[i] = RefNbrList[i] + CheckNbrList[i];
                        }
                        for (int i = 0; i < RefNbrList.Length; i++)
                        {
                            RefNbrList[i] = SpaceMaker(RefNbrList[i]);
                        }
                        Console.Clear();
                        Console.WriteLine("Uudet viitenumerosi:\n");
                        Console.WriteLine(RefNbrList[amount]);
                        break;
                    }

            }
        }
        static string ReferenceNumber ()
        {
            Console.WriteLine("Syötä viitenumero!");
            return Console.ReadLine();
        }
        static string Reverse (string r)
        {
            char[] CharArray = r.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray);
        }
        static string CheckMark (string n)
        {
            string check = string.Empty;
            int sum = 0;
            int[] list = new int[n.Length];
            for (int i = 0; i < n.Length; i++)
            {
                list[i] = int.Parse(n.Substring(i, 1));
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 3 == 0)
                {
                    list[i] = list[i] * 7;
                }
                else if (i % 3 == 1)
                {
                    list[i] = list[i] * 3;
                }
                else
                {
                    list[i] = list[i];
                }
            }
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            int difference = (int)(Math.Ceiling(sum / 10.0d) * 10);
            check = (difference - sum).ToString();
            return check;
        }
        static bool CheckNbrChecker (string Nbr1, string Nbr2)
        {
            if (Nbr1 == Nbr2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string SpaceMaker(string s)
        {
            int g = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (g > 2)
                    break;
                if (i >= 5 && i % 5 == 0)
                {
                    s = s.Insert(s.Length - i - g, " ");
                    g = g + 1;
                }
            }
            return s;
        }
        static int Amount()
        {
            int i;
            do
            {
                Console.Write("Syötä numeroin kuinka monta viitenumeroa haluat!");
                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.Clear();
                    Console.WriteLine("Syöte ei ole numero!");
                    Console.Write("Syötä numeroin kuinka monta viitenumeroa haluat!");
                }
                if (i < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Luku ei voi olla pienempi kuin 1!");
                }
            }
            while (i < 1);
            return i;
        }
        static string[] ListMaker(string b, int a)
        {
            string[] list = new string[a];
            for (int i = 0; i < a; i++)
            {
                list[i] = b + (i + 1).ToString();
            }
            return list;
        }
    }
}
