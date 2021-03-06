﻿using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
            int[] arrT_3 = ComparingArray (arrT_1, arrT_2);

            PrintData(arrT_1, "arrT_1: ");
            PrintData(arrT_2, "arrT_2: ");
            PrintData(arrT_3, "arrT_3: ");
        }
        static int[] RndArray(int rand)
        {
             Random rnd = new Random();
            int[] arrT = new int[rand];

             for (int i = 0; i < rand; i++)
             {
                arrT[i] =  rnd.Next(20);
             }

             return arrT; 
        }
        static int[] ComparingArray(int[] array1, int[] array2)
        {
            int[] arrT = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                    arrT[i] = array1[i];
                else
                    arrT[i] = array2[i];
            }
            return arrT;
        }
        static void PrintData(int [] arrX, string label)
        {
          Console.Write($"{label} ");
          for (int i = 0; i < arrX.Length; i++)
          {
            Console.Write($"{arrX[i] :d2} ");
          }
            Console.WriteLine();
        }
    }
}
