using System;

namespace дз_5__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано слово: прогулка. Составить слова горка и порог");
            Console.ReadKey();
            string m = "прогулка";
            string ответ1 = m.Substring(3, 1)
                + m.Substring(2, 1)
                + m.Substring(1, 1)
                + m.Substring(6, 2);
            Console.WriteLine(ответ1);
            Console.ReadKey();

            string ответ2 = m.Substring(0, 1)
                + m.Substring(2, 1)
                + m.Substring(1, 2)
                + m.Substring(3, 1);
            Console.WriteLine(ответ2);
            Console.ReadKey();

        }
    }
}
