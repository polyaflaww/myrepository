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
        }
    }
}
