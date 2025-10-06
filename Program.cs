using System;
using System.Text;

namespace IntroductionCSharp
{
   internal class Program
   {
      static void Main()
      {
         int v;
         do
         {
            Console.WriteLine("Введите значение элемента:");
            int.TryParse(Console.ReadLine(), out v);
            //v = Convert.ToInt32(Console.ReadLine());
            if (v <= -100 || v >= 100)
            {
               Console.WriteLine("Введено не верное значение");
            }
         } while (v <= -100 || v >= 100);


         string stroka = null;
         int[] arrayInt = { };
         // Определение количества столбцов в строке разделением строки на подстроки по пробелу
         // Символ пробела
         char symbolSpace = ' ';
         // Счетчик символов
         int symbolСount = 0;
         // Количество столбцов в строке
         int сolumn = 0;

         //Console.WriteLine("Исходный строковый массив:");
         //Console.WriteLine(stroka);
         while (symbolСount < stroka.Length)
         {
            if (symbolSpace == stroka[symbolСount])
            {
               сolumn++;
            }

            if (symbolСount == stroka.Length - 1)
            {
               сolumn++;
            }

            symbolСount++;
         }


         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Программа определения максимального числа из двух целых чисел");
         Console.WriteLine("-------------------------------------------------------------");
         Console.Write("Введите первое число: ");
         int a = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите второе число: ");
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
         int sr;
         bool succes = int.TryParse(Console.ReadLine(), out sr);
         int s = 0;
         while (s == 0)
         {
            if (succes)
            {
               s = 1;
            }
            else
            {
               Console.Write("Введите целое, а не дробное число: ");
               succes = int.TryParse(Console.ReadLine(), out sr);
               s = 0;
            }
         }

         if (sr == 0)
         {
            Console.WriteLine("Число 0 не является четным и нечетным числом");
         }
         else
         {
            if (sr % 2 == 0)
            {
               Console.WriteLine("Число " + sr + " - является четным");
            }
            else
            {
               Console.WriteLine("Число " + sr + " - является нечетным");
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

         Console.ReadKey();
      }
   }
}