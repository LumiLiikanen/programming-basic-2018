using System;

namespace HeTu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma luo Henkilötunnuksen!");
            Console.WriteLine("Syötä syntymäpäivä pp/kk/vvvv");
            string input = Console.ReadLine();
            string date = input.Replace("/", "");
            string input1= input.Remove(4, 2);
            if (IsDate(date))
            {
                string ending = EndingGenerator();
                string checkmark = CheckMarkGenerator(input1, ending);
                PrintData(date, ending, checkmark);
            }
        }
        public static bool IsDate(string d)
        {
            int day = int.Parse(d.Substring(0, 2));
            int month = int.Parse(d.Substring(2, 2));
            int year = int.Parse(d.Substring(4, 4));
            try
            {
                DateTime date1 = new DateTime(year, month, day);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static string EndingGenerator ()
        {
            Random ending = new Random();
            string[] endingarray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                endingarray[i] = ending.Next(10).ToString();
                if (endingarray[0] == "9")
                {
                    i--;
                }
                else if (endingarray[2] == "0" || endingarray[2] == "1")
                {
                    i--;
                }
            }
            Console.WriteLine();
            string endstring = "";
            for (int i = 0; i < 3; i++)
            {
                endstring += endingarray[i].ToString();
            }
            return endstring;
        }
        public static string CheckMarkGenerator (string date, string ending)
        {
            string checkmark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string StartHeTu = date + ending;
            int HeTuCheck = int.Parse(StartHeTu);
            HeTuCheck = HeTuCheck % 31;
            string x = checkmark[HeTuCheck].ToString();
            return x;
        }
        public static void PrintData (string a, string b, string c)
        {
            int year = int.Parse(a.Substring(4));
            string hetu;
            if (year < 1900)
                hetu = a.Remove(4, 2) + "+" + b + c;
            else if (year >= 1900 && year < 2000)
                hetu = a.Remove(4, 2) + "-" + b + c;
            else
                hetu = a.Remove(4, 2) + "A" + b + c;
            Console.WriteLine($"Henilötunnuksesi on {hetu}");
        }
    }
}
