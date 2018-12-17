using System;

namespace HeTu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa onko henkilötunnus oikein!");
            Console.WriteLine("Syötä henkilötunnus!");
            string input = Console.ReadLine();
            // Console.WriteLine(IsDate());
            int dd = GetNumber(input, 0, 2);
            int mm = GetNumber(input, 2, 2);
            int yy = GetNumber(input, 4, 2);
            int tt = GetNumber(input, 7, 3);
            string hetuchecker = Checker(input);
            bool isReal = FinalCheck(hetuchecker, input.Substring(10));
            PrintData(isReal);
        }
        public static int GetNumber(string input, int startPosition, int length)
        {
            string newinput = input.Substring(startPosition, length);    
            return int.Parse(newinput);
        }
        public static bool IsDate(int year, int month, int day)
        {
           
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }           
        public static string Checker (string input)
        {
            string chekmark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string inputtmp = input.Remove(6, 1);
            int check = int.Parse(inputtmp.Remove(9));
            check = check % 31;
            string x = chekmark[check].ToString();
            return x;
        }
        public static bool FinalCheck(string letter1, string letter2)
        {
            if (letter2 == letter1)
                return true;
            else
                return false;
        }
        static void PrintData (bool data)
        {
            if (data)
                Console.WriteLine("Henkilötunnus on oikea!");
            else
                Console.WriteLine("Henkilötunnus on väärä!");
        }
    }
}
