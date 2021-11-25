
using System;

namespace дз_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите заглавными буквами текст на английском языке");
           string x = Console.ReadLine();
            x = x.Replace("A", "4");
            x = x.Replace("B", "8");
            x = x.Replace("C", "(");
            x = x.Replace("D", "|)");
            x = x.Replace("E", "3");
            x = x.Replace("F", "|=");
            x = x.Replace("G", "6");
            x = x.Replace("H", "|-|");
            x = x.Replace("I", "!");
            x = x.Replace("J", ")");
            x = x.Replace("K", " |<");
            x = x.Replace("L", "1");
            x = x.Replace("M", "|\\/|");
            x = x.Replace("N", "|\\|");
            x = x.Replace("O", "0");
            x = x.Replace("P", " |>");
            x = x.Replace("Q", "9");
            x = x.Replace("R", " |2");
            x = x.Replace("S", "5");
            x = x.Replace("T", "7");
            x = x.Replace("U", "|_|");
            x = x.Replace("V", "\\/");
            x = x.Replace("W", "\\/\\/");
            x = x.Replace("X", "><");
            x = x.Replace("Y", "'/");
            x = x.Replace("Z", "2");
            Console.WriteLine(x);
            Console.ReadKey();

            
        }
    }
}
