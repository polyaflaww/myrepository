using System;

namespace дз_8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m;
            Console.WriteLine("Вычисление суммы чисел с одинаковой степенью");
            Console.WriteLine("Введите значение для показателя степени");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для последнего числа в ряду");
            m = int.Parse(Console.ReadLine());

                    double a = 0;            
            for (int i = 1; i <= m; i++)
                {
                    a += Math.Pow(i, n);
                }
            
            if(n == 2)
            {
                Console.WriteLine($"Сумма ряда чисел во {n} степени равняется {a}");
            }
            else
            Console.WriteLine($"Сумма ряда чисел в {n} степени равняется {a}");
        }
    }
}
