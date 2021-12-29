using System;

namespace дз_8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int g = 0;              //подсчет количества делителей
            int j;                  //подсчет делителей у наибольшего простого делителя для доказательства, что он - простой
            Console.WriteLine("Вычисление наибольшего простого делителя числа n");
            Console.WriteLine("Введите число n");
            n = int.Parse(Console.ReadLine());
            int i = n;              //наибольший делитель числа

            while (i > 0)
            {
                if(n % i==0)
                {
                    j = i;
                    while(j > 0)
                        {
                        if(i % j == 0)
                        {
                            g++;
                        }
                        j--;
                    }
                    if(g==2)
                    {
                        Console.WriteLine("Наибольший простой делитель числа " + n + ": " + i);
                    break;
                    }
                    g = 0;
                }
                i--;
            }

        }
    }
}
