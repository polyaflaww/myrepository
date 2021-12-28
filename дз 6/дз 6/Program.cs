using System;

namespace дз_6
{
    class Program
    {
        static int method(int n)
        {
            return n / 5;
        }
        static int method2(int n)
        {
            return n / 8;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Вычисление значения логического выражения");
            Console.WriteLine("Введите любое целое число");
            n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
            {
                int z = method(n);
                Console.WriteLine("Не удовлетворяет условию, кратно 5");

                if (n % 8 == 0)
                {
                    int y = method2(n);
                    Console.WriteLine("Не удовлетворяет условию, кратно 8, F=0");
                }
                else
                    Console.WriteLine("Удовлетворяет условию не кратности 8, F=0");
            }
            else
            {
                if (n % 8 == 0)
                {
                    Console.WriteLine("Не удовлетворяет условию, кратно 8");
                    Console.WriteLine("Удовлетворяет условию не кратности 5, F=0");
                }
                else
                    Console.WriteLine("Удовлетворяет условиям не кратности 5 и 8, F=1");
            }
                
            Console.ReadKey();
        }
    }
}
