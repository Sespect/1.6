using System;

class Program
{
    public static void Main()
    {
        Console.Write("������� ������������� �����: ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("������������ ����");
            return;
        }

        int sum = 0;
        Console.WriteLine("������� ������������� ����� (��� ���������� ������� �������������): ");

        int number = 1;
        while (number > 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number % a == 0)
            {
                sum += number;
            }
        }
        Console.WriteLine($"����� �����, ��������� �� {a}, ����� {sum}");
    }
}