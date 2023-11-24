using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string numsTask1 = "numsTask1.txt";

        Console.Write("Введите количество слов: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите слова:");
        using (StreamWriter writer = new StreamWriter(numsTask1))
        {
            for (int i = 0; i < n; ++i)
            {
                string word = Console.ReadLine();
                writer.WriteLine(word);
            }
        }

        using (StreamReader reader = new StreamReader(numsTask1))
        {
            Console.WriteLine("Слова нечетной длины:");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Length % 2 != 0) //длина строки line нечетная
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}