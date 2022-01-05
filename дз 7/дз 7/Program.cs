using System;

namespace дз_7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения функции f(x)");
            Console.WriteLine("Введите значение переменной х");
            double x = double.Parse(Console.ReadLine());
            Method(x);
        }

        static void Method(double x)
        {
            if (x < 2)
            {
                double y = x - 2;
                Console.WriteLine("Значение функции равно " + y);
            }
            else if (x > 3)
            {
                double y = 3 - x;
                Console.WriteLine("Значение функции равно " + y);
            }
            else
            {
                double y = 0;
                Console.WriteLine("Значение функции равно " + y);
            }
            Console.ReadKey();
        }
    }
}
