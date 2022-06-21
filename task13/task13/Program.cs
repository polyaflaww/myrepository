using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace task13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите путь к файлу или напишите название, если он находится в папке с программой");
            string path = Console.ReadLine();//Metamorphosis.txt
            string text = ReadText(path);
            char[] separators = new char[] { ' ', '.', ',', '"', '!', ';', '?', ':' };
            string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string sub1 in subs)
            {
                subs[i] = sub1.ToLower();
                i++;
            }

            var words = new Dictionary<string, int>();
            for (int j = 0; j < subs.Length; j++)
            {
                if (subs[j].Length > 3)
                    if (words.ContainsKey(subs[j]) == false)
                    words.Add(subs[j], 1);
                    else
                        words[subs[j]] += 1;
            }

            List<KeyValuePair<string, int>> sortwords = words.ToList();
            sortwords.Sort((x, y) => y.Value.CompareTo(x.Value));
            var result = new string[2];
            for (int l = 0; l < 50; l++)
            {
                Console.WriteLine($"Слово {sortwords[l].Key}, Частота: {sortwords[l].Value}");
            }

            Console.ReadKey();
        }
        static string ReadText(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                return (text);
            }
        }
    }
}

