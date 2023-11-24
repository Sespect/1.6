using System;

class Program
{
    static void Main()
    {
        Console.Write("������� ���������� �����: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("������� ���������� �������� (����� ���������� ������������� �������): ");
        int m = int.Parse(Console.ReadLine());

        if (n == m)
        {
            Console.Write("������������ ����, ������� �� �������������!");
            return;
        }

        int[,] a = new int[n, m];
        Random random = new Random();
        Console.WriteLine("�������� �������:");
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                a[i, j] = random.Next(0, 2);
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] b = new int[n, m + 1];
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                b[i, j] = a[i, j];
            }

            int sumOnes = 0;
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == 1)
                {
                    sumOnes++;
                }
            }

            if (sumOnes % 2 == 0)
            {
                b[i, m] = 0;
            }
            else
            {
                b[i, m] = 1;
            }
        }

        Console.WriteLine("����� ������� � �������������� ��������:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(b[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}