using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is not even");
        }

        if (number % 10 == 0)
        {
            Console.WriteLine("The number is a multiple of 10");
        }
        else
        {
            Console.WriteLine("The number is not a multiple of 10");
        }
    }
}