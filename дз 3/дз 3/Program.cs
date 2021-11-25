using System;

namespace дз_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения выражения с переменными");
            Console.ReadKey();
            Console.WriteLine("y = (-x^3 + 1) / (x^2 + 1)");
            Console.ReadKey();
            Console.WriteLine($"Введите значение x");
            int x = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("у равен:");
            Console.WriteLine((-x*x*x + 1 )/ (x*x + 1));
            Console.ReadKey();
        }
    }
}
