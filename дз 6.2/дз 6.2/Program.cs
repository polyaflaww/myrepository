using System;

namespace дз_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Определение принадлежности точки с координатами (х;у) указанной области");
            Console.WriteLine("Введите x");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            var y = double.Parse(Console.ReadLine());

            if (y > -2 && y < 1.5)
            {
                Console.WriteLine("Точка с координатами (" + x + ";" + y + ") принадлежит указанной области");
            }
            else
                Console.WriteLine("Точка с координатами (" + x + ";" + y + ") не принадлежит указанной области");

            Console.ReadKey();
        }
    }
}
