using System;

namespace дз_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление суммы максимальной и минимальной цифр в десятичной записи числа");
            Console.Write("Введите число: ");
            string n = Console.ReadLine();

            int max = int.Parse(n[0].ToString());
            int min = max;

            for (int i = 1; i < n.Length; i++)
            {
                if (max < int.Parse(n[i].ToString()))
                    max = int.Parse(n[i].ToString());
            }

            for (int i = 1; i < n.Length; i++)
            {
                if (min > int.Parse(n[i].ToString()))
                    min = int.Parse(n[i].ToString());
            }
            Console.WriteLine("Сумма максимальной и минимальной цифр = {0}", max + min);
            Console.ReadKey();
        }
    }
}
