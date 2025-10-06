using System;

namespace IntroductionCSharp
{
   internal class Program
   {
      static void Main()
      {
         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Программа определения максимального числа из двух целых чисел");
         Console.WriteLine("-------------------------------------------------------------");
         Console.Write("Введите первое число: "); //
         int a = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите второе число: "); //
         int b = Convert.ToInt32(Console.ReadLine());
         if (a == b)
         {
            Console.WriteLine("Числа равны: {0} = {1}", a, b);
         }
         else
         {
            if (a > b)
            {
               Console.WriteLine("Максимальное число: " + a);
            }
            else
            {
               Console.WriteLine("Максимальное число: " + b);
            }
         }

         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Программа определения максимального числа из трех целых чисел");
         Console.WriteLine("--------------------------------------------------===========");
         Console.Write("Введите первое число: ");
         int a1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите второе число: ");
         int a2 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите третье число: ");
         int a3 = Convert.ToInt32(Console.ReadLine());
         int max = a1;
         if (a1 == a2 && a2 == a3)
         {
            Console.WriteLine("Числа равны: {0} = {1}= {2}", a1, a2, a3);
         }

         if (a1 > max)
         {
            max = a1;
         }

         if (a2 > max)
         {
            max = a2;
         }

         if (a3 > max)
         {
            max = a3;
         }

         Console.WriteLine("Максимальное число: " + max);

         Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Программа определения четности целого числа");
         Console.WriteLine("-------------------------------------------");
         Console.Write("Введите целое число: ");
         string sr = Console.ReadLine();
         int s = 0;
         while (s == 0)
         {
            if (sr.Contains(","))
            {
               Console.WriteLine("Введите целое, а не дробное число");
               sr = Console.ReadLine();
               s = 0;
            }
            else
            {
               s = 1;
            }
         }
         int x = int.Parse(sr);
         if (x == 0)
         {
            Console.WriteLine("Число 0 не является четным и нечетным числом");
         }
         else
         {
            if (x % 2 == 0)
            {
               Console.WriteLine("Число " + x + " - является четным");
            }
            else
            {
               Console.WriteLine("Число " + x + " - является нечетным");
            }
         }

         Console.WriteLine("-------------------------------------------------------------------------");
         Console.WriteLine("Программа вывода всех четных чисел от 1 до N, включая отрицательные числа");
         Console.WriteLine("-------------------------------------------------------------------------");
         Console.Write("Введите число целое N: ");
         int n = Convert.ToInt32(Console.ReadLine());
         Console.Write("Ряд четных чисел: ");
         if (n == 0)
         {
            Console.WriteLine("N должно быть отличным от 0");
         }
         else
         {
            if (n > 0)
            {
               for (int i = 1; i <= n; i++)
               {
                  if (i % 2 == 0)
                     Console.Write("{0} ", +i);
               }
            }
            else
            {
               for (int i = -1; i >= n; i--)
               {
                  if (i % 2 == 0)
                     Console.Write("{0} ", +i);
               }
            }
         }
      }
   }
}