using System;

namespace ЗАЧЕТ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с сиракузской последовательностью");
            Console.WriteLine("Введите натуральное число n");
            int n;
            n = int.Parse(Console.ReadLine());
            int sum = 1;
            while (n != 1)
            {
                if (n % 2 == 0)
                { 
                    n = n / 2;
                    sum += 1;
                }
                else
                {
                    n = 3 * n + 1;
                    sum += 1;
                 }
            }
                Console.WriteLine("Длина сиракузской последовательности равна: " + sum);

            int nMaximum = 0;
            if (n > nMaximum)
            {
                nMaximum = n;
            }
               Console.WriteLine("Максимальное число в последовательности: " + nMaximum);
        }
        }
    }

