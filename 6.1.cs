using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        string numsTask1 = "numsTask1.txt";

        Console.Write("Enter numbers of words: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter words:");
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
            Console.WriteLine("odd length words:");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Length % 2 != 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}