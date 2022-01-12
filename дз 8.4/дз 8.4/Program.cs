using System;

namespace дз_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы максимальной и минимальной цифр в десятичной записи числа");
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            int max = 0;
            int min = 10;

            while (n > 0)
            {
                if (max < n % 10)
                {
                    max = n % 10;
                }

                if (min > n % 10)
                {
                    min = n % 10;
                }
                n /= 10;
            }
            Console.WriteLine("Сумма максимальной и минимальной цифр = {0}", max + min);
            Console.ReadKey();
        }
    }
}
