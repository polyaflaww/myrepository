using System;

namespace дз_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения x");
            int m = 3;
            double e = Method(m);
            Console.WriteLine("Значение х равно " + e);
            Console.ReadKey();
        }

        static double Method2(int m)
        {
            double y = Math.Pow(m, 3) + 1;
            return y;
        }
        static double Method(int m)
        {
            m = 3;
            double k = Method2(m);
            double a = Math.Round(Math.Sin((Math.Pow(2, 2) + 1) / k), 3);
            double b = Math.Round(Math.Sin(k / (Math.Pow(5, 5) + 1)), 3);
            double c = Math.Round(Math.Sin((Math.Pow(4, 4) + 1) / k), 3);
            double sum = a + b + c;
            return sum;
        }


    }
}
