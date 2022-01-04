using System;

namespace дз_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Вычисление значения логического выражения");
            Console.WriteLine("Введите любое целое число");
            n = int.Parse(Console.ReadLine());
            Method(n);

        static void Method(int n)
        {
            if (n % 5 == 0 && n % 8 == 0)
            {
                    Console.WriteLine("Не удовлетворяет условию не кратности 5 и 8, невозможно вычислить значение выражения");
            }
                else if (n % 5 == 0 || n % 8 == 0)
            { 
                    Console.WriteLine("Невозможно вычислить значение выражения");
            }
            else
            {
                Console.WriteLine("Удовлетворяет условиям не кратности 5 и 8, значение выражений равно: " + (float)n/5 + " и " + (float)n/8);
            }
        }
            Console.ReadKey();

            
        }
    }
}
