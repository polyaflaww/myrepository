using System;

namespace дз_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения x");
            Console.ReadKey();
            Console.WriteLine("x = sin((2^2+1)/(3^3+1)) + sin((3^3+1)/(5^5+1)) + sin((4^4+1)/(3^3+1))");
            Console.ReadKey();
            Console.WriteLine("x равен:");
            Console.ReadKey();
            var y = Math.Round(Math.Sin((2 * 2 + 1) / (3 * 3 * 3 + 1)), 3);
            var z = Math.Round(Math.Sin((3*3*3 + 1) / (5*5*5*5*5 + 1)), 3);
            var m = Math.Round(Math.Sin((4*4*4*4 + 1) / (3*3*3 + 1)), 3);
            double x = y + z + m;
            Console.WriteLine(x = y + z + m);
            Console.ReadKey();
        }
    }
}
