using System;
class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,,] matrix = new int[2, n, n];
        int num = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[0, row, col] = num;
                num++;
            }
        }
        num = 1;
        for (int col = 0; col < n; col+=2)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[1, row, col] = num;
                num++;
            }
            num += n;
        }
        num = n + 1;
        for (int col = 1; col < n; col+=2)
        {
            for (int row = n - 1; row >= 0; row--)
            {
                matrix[1, row, col] = num;
                num++;
            }
            num += n;
        }
        Console.WriteLine("Pattern A:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[0, row, col] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Pattern B:");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[1, row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

