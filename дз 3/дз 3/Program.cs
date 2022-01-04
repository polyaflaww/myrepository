using System;

namespace дз_3
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения выражения с переменными");
            Console.WriteLine("Введите значение х");
            int x = int.Parse(Console.ReadLine());
            double z = Method(x);
            Console.WriteLine("Значение функции равно " + z);

            static double Method(int x)
                {
                double y = (Math.Pow(x, 3) * (-1) + 1 / (Math.Pow(x, 2) + 1)) / (1 + 5 / (Math.Pow(x, 2) + x + 1));
                return y;
                }
        }
    }
}
