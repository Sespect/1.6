using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("������� �����: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("����� �������� ������");
        }
        else
        {
            Console.WriteLine("����� �� �������� ������");
        }

        if (number % 10 == 0)
        {
            Console.WriteLine("����� �������� ������� 10");
        }
        else
        {
            Console.WriteLine("����� �� �������� ������� 10");
        }
    }
}