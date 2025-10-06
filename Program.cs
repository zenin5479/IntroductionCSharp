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
         int c = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите второе число: ");
         int d = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите третье число: ");
         int f = Convert.ToInt32(Console.ReadLine());
         int max = c;
         if (c == d && d == f)
         {
            Console.WriteLine("Числа равны: {0} = {1} = {2}", c, d, f);
         }
         else
         {
            if (c == d)
            {
               Console.WriteLine("Первое и второе число равны: {0} = {1}", c, d);
            }

            if (d == f)
            {
               Console.WriteLine("Второе и третье число равны: {0} = {1}", d, f);
            }

            if (c == f)
            {
               Console.WriteLine("Первое и третье число равны: {0} = {1}", c, f);
            }

            if (c > max)
            {
               max = c;
            }

            if (d > max)
            {
               max = d;
            }

            if (f > max)
            {
               max = f;
            }
         }

         Console.WriteLine("Максимальное число: " + max);

         Console.WriteLine("-------------------------------------------");
         Console.WriteLine("Программа определения четности целого числа");
         Console.WriteLine("-------------------------------------------");
         Console.Write("Введите целое число: ");



         string sr = "";
         int.TryParse(Console.ReadLine(), out n);
         n = Convert.ToInt32(Console.ReadLine());
         if (n <= 0 || n > 20)
         {
            Console.WriteLine("Введено не верное значение");
         }



         
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