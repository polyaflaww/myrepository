using System;

namespace дз_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            Console.WriteLine("Вычисление суммы знакопеременного ряда");
            Console.WriteLine("Введите число n для расчета суммы, n НЕ равно 0");
            n = double.Parse(Console.ReadLine());

            double sum = 0;
            for(double i = 1; i <= n; i++)
            {
                if((n + 1) % 2 == 0)
                {
                    sum = sum - 1 / n;
                }
                else
                sum = sum + 1 / n;
            }
            Console.WriteLine("Сумма ряда равна " + sum);
            Console.ReadKey();

            Method3(1, 0);
            Method4(0, 10);
            Method6(0, 1);
        }
        static void Method3(double n1, double sum1)
        {
            Console.WriteLine("Вычисление возможных значений переменной n в гармоническом ряде, при котором сумма элементов меньше значения а");
            Console.WriteLine("Введите число а для расчета всех значений, a > 1");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Все значения n, при которых значение выражения меньше а:");
            n1 = 1;
            sum1 = 0;

            while (sum1 < a)
            {
                sum1 += 1 / n1;
                Console.WriteLine(n1);
                n1++;
            }
        }
        static void Method4(int max, int min)
        {
            Console.WriteLine("Вычисление суммы максимальной и минимальной цифр в десятичной записи числа");
            Console.Write("Введите число: ");
            int k = int.Parse(Console.ReadLine());

             max = 0;
             min = 10;

            while (k > 0)
            {
                if (max < k % 10)
                {
                    max = k % 10;
                }

                if (min > k % 10)
                {
                    min = k % 10;
                }
                k /= 10;
            }
            Console.WriteLine("Сумма максимальной и минимальной цифр = {0}", max + min);
            Console.ReadKey();
        }
        static void Method6(double a, int b)
        {
            int n;
            int m;
            Console.WriteLine("Вычисление суммы чисел с одинаковой степенью");
            Console.WriteLine("Введите значение для показателя степени");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для последнего числа в ряду");
            m = int.Parse(Console.ReadLine());

                     a = 0;
            for (int i = 1; i <= m; i++)
            {
                     b = 1;
                for (int j = 1; j <= n; j++)
                {
                    b = b * i;
                }
                a += b;
            }

            if (n == 2)
            {
                Console.WriteLine($"Сумма ряда чисел во {n} степени равняется {a}");
            }
            else
                Console.WriteLine($"Сумма ряда чисел в {n} степени равняется {a}");
            Console.ReadKey();
        }
    }
}
