using System;
using System.Linq;
class MaxSum
{
    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        input[0]++;
        input[1]++;
        int[,] matrix = new int[input[0], input[1]];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = line[col];
            }
        }
        int maxRow = 0;
        int maxCol = 0;
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = 0;
                sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("Sum = {0}", maxSum);
        for (int row = maxRow; row < maxRow + 3; row++)
        {
            for (int col = maxCol; col < maxCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

