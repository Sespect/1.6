using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int n = random.Next(1, 20);
        Console.WriteLine($"Размер массива: {n}");

        double[] sourceArray = new double[n];
        for (int i = 0; i < n; ++i)
        {
            sourceArray[i] = random.NextDouble() * (100 + 100) - 100;
        }

        double[] positiveArray = new double[n];
        double[] negativeArray = new double[n];
        int positiveElements = 0;
        int negativeElements = 0;

        foreach (double number in sourceArray)
        {
            if (number > 0)
            {
                positiveArray[positiveElements] = number;
                positiveElements++;
            }
            else if (number < 0)
            {
                negativeArray[negativeElements] = number;
                negativeElements++;
            }
        }

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < n; ++i)
        {
            Console.Write($"{sourceArray[i]:f2} ");
        }
        Console.WriteLine();

        if (positiveElements > 0)
        {
            Console.WriteLine("Положительные элементы:");
            for (int i = 0; i < positiveElements; ++i)
            {
                Console.Write($"{positiveArray[i]:f2} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Положительные элементы отсутствуют");
        }

        if (negativeElements > 0)
        {
            Console.WriteLine("Отрицательные элементы:");
            for (int i = 0; i < negativeElements; ++i)
            {
                Console.Write($"{negativeArray[i]:f2} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Отрицательные элементы отсутствуют");
        }
    }
}