using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter a positive number: ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("Incorrect input");
            return;
        }

        int sum = 0;
        Console.WriteLine("Enter positive numbers (to complete, enter negative): ");

        int number = 1;
        while (number > 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number % a == 0)
            {
                sum += number;
            }
        }
        Console.WriteLine($"The sum of the numbers divisible by {a} is equal to {sum}");
    }
}