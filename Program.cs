﻿using System;

namespace IntroductionCSharp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Программа определения максимального числа из двух целых чисел");
         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Введите первое число: ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите второе число: ");
         int b = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Первое число = " + a + ";");
         Console.WriteLine("Второе число = " + b + ";");
         if (a == b)
         {
            Console.WriteLine("Числа равны: {0} = {1}", a, b);
         }
         else
         {
            if (a > b)
            {
               Console.WriteLine("Максимальное число = " + a);
            }
            else
            {
               Console.WriteLine("Максимальное число = " + b);
            }
         }

         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Программа определения максимального числа из трех целых чисел");
         Console.WriteLine("--------------------------------------------------===========");
         Console.WriteLine("Введите первое число:");
         double a1 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Введите второе число:");
         double a2 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Введите третье число:");
         double a3 = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("a = " + a1 + ";  " + "b = " + a2 + ";  " + "c = " + a3);
         double max = a1;
         if (a1 > max) max = a1;
         if (a2 > max) max = a2;
         if (a3 > max) max = a3;
         Console.WriteLine("max = " + max);

         Console.WriteLine("");
         Console.WriteLine("--------------------------------------------------");
         Console.WriteLine("Программа определения четности числа");
         Console.WriteLine("--------------------------------------------------");
         Console.WriteLine("Введите целое число:");
         string sr = Console.ReadLine();
         int s = 0;
         while (s == 0)
         {
            if (sr.Contains(","))
            {
               Console.WriteLine("введите целое, а не дробное число");
               sr = Console.ReadLine();
               s = 0;
            }
            else s = 1;
         }
         int x = int.Parse(sr);
         if (x == 0)
            Console.WriteLine("Число 0 не является четным и нечетным числом");
         else
         {
            if (x % 2 == 0)
               Console.WriteLine("число  " + x + "  - является четным");
            else
               Console.WriteLine("число  " + x + "  - является нечетным");
         }

         Console.WriteLine("");
         Console.WriteLine("--------------------------------------------------");
         Console.WriteLine("Прогнрамма вывода всех четных чисел от 1 до N, включая отрицательные числа");
         Console.WriteLine("--------------------------------------------------");
         Console.WriteLine("введите число целое  N ");
         int N = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("ряд четных чисел:");
         if (N == 0) Console.WriteLine(" N должно быть отличным от 0");
         else
         {
            if (N > 0)
            {
               for (int i = 1; i <= N; i++)
               {
                  if (i % 2 == 0)
                     Console.WriteLine(i);
               }
            }
            else
            {
               for (int i = -1; i >= N; i--)
               {
                  if (i % 2 == 0)
                     Console.WriteLine(i);
               }
            }
         }
      }
   }
}