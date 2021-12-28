using System;

namespace дз_7
{
    class Program
    {
        static int function(int x, int y)
        {
            return y = x - 2;
        }
        static int function2(int x, int y)
        {
            return y = 0;
        }
        static int function3(int x, int y)
        {
            return y = 3 - x;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Вычисление значения функции f(x)");
            Console.WriteLine("Введите значение переменной х");
            x = int.Parse(Console.ReadLine());

            if(x<2)
            {
                int a = function(x, x-2);
                Console.WriteLine("Функция f(x) равна " + a);
            }

            else if(x >= 2 && x <= 3)
            {
                int b = function2(x, 0);
                Console.WriteLine("Функция f(x) равна " + b);
            }
                
            else if(x > 3)
            {
                int c = function3(x, 3 - x);
                Console.WriteLine("Функция f(x) равна " + c);
            }
            Console.ReadKey();
        }
    }
}
