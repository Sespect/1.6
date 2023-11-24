using System;

class Program
{
    public static void Main()
    {
        Console.Write("Введите положительное число: ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("Некорректный ввод");
            return;
        }

        int sum = 0;
        Console.WriteLine("Введите положительные числа (для завершения введите отрицательное): ");

        int number = 1;
        while (number > 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number % a == 0)
            {
                sum += number;
            }
        }
        Console.WriteLine($"Сумма чисел, делящихся на {a}, равна {sum}");
    }
}