using System;

namespace VokaaliLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syöteessä olevien vokaalien määrän!");
            Console.WriteLine("Syötä lause tai sana!");
            string input = Console.ReadLine();
            int j = 0;
            string inputtmp = input.ToLower();
            string vowels = "aeiouyåäö";
            
            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < vowels.Length; k++)
                {

                    if (inputtmp[i] == vowels[k])
                    {
                        j++;
                        break;
                    }
                }
            }
          Console.WriteLine($"{input} sisältää {j} vokaalia");
        }
    }
}
