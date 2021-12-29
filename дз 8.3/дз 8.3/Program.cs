using System;

namespace дз_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление возможных значений переменной n в гармоническом ряде, при котором сумма элементов меньше значения а");
            Console.WriteLine("Введите число а для расчета всех значений, a > 1");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Все значения n, при которых значение выражения меньше а:");
            double n = 1;
            double sum = 0;

            while (sum < a)
            {
                sum += 1 / n;
                Console.WriteLine(n);
                n++;
            }
        }
    }
}
