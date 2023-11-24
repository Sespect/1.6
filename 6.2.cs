using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string numsTask2 = "numsTask2.txt";

        Console.Write("¬ведите количество слов: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("¬ведите слова:");
        using (StreamWriter writer = new StreamWriter(numsTask2))
        {
            for (int i = 0; i < n; ++i)
            {
                string word = Console.ReadLine();
                writer.WriteLine(word);
            }
        }

        using (StreamReader reader = new StreamReader(numsTask2))
        {
            string line;
            string finalLine = "";
            while ((line = reader.ReadLine()) != null)
            {
                finalLine += line + " ";
            }
            Console.WriteLine("ќдна длинна€ строка:");
            Console.WriteLine(finalLine);
        }
    }
}