using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Число является четным");
        }
        else
        {
            Console.WriteLine("Число не является четным");
        }

        if (number % 10 == 0)
        {
            Console.WriteLine("Число является кратным 10");
        }
        else
        {
            Console.WriteLine("Число не является кратным 10");
        }
    }
}