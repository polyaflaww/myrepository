using System;

namespace дз_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работа с массивом текста");
            Console.WriteLine("Введите одной строкой текст");
            string str1 = Console.ReadLine();
            string str2 = str1.ToLower();
            string[] array = str2.Split(' ');
            Method(array);
            FirstLetterToUpper(str2);

            static string FirstLetterToUpper(string str2)
            {
                if (str2.Length > 0) 
                {
                    return Char.ToUpper(str2[0]) + str2.Substring(1);
                }
                return "";
            }
            static void Method(string[] array)
            {
                foreach (string i in array)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("Среднее арифметическое длины слов массива:");
        }
        private static double GetMiddle(string[] array)
        {
            var sum = 0.0d;
            var count = 0;

            for (var index = 0; index < array.Length; index++)
            {
                    sum += index;
                    count++;  
            }
            return sum / count;
        }

      }
      
    }
    

