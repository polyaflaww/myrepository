using System;

namespace дз_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Определение принадлежности точки с координатами (х;у) указанной области");
            bool belong = true;
            bool dontbelong = false;
            double x;
            double y;
                Console.WriteLine("Введите x: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y: ");
                y = double.Parse(Console.ReadLine());
                if (y < -2 || y > 1.5)
                {
                Console.WriteLine(dontbelong);
                Console.WriteLine("Точка с координатами (" + x + ";" + y + ") не принадлежит области");
            }
                else
                {
                Console.WriteLine(belong);
                Console.WriteLine("Точка с координатами (" + x + ";" + y + ") принадлежит области");
            }
            Console.ReadKey();



        }
    }
}
