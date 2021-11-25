using System;

namespace дз_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=2, g=3;
            Console.WriteLine("Геометрическая прогрессия");
            Console.ReadKey();
            Console.WriteLine("b=2, g=3");
            Console.WriteLine($"Введите номер n для вычисления n-го члена геометрической прогрессии");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Член прогрессии с номером n равен");
            Console.WriteLine(b * (Math.Pow(g, num - 1)));
            Console.ReadKey();
        }
    }
}
