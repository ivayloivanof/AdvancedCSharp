using System;
using System.Linq;

class MatrixMaximalSum
{
    static void Main()
    {
        int[] field = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        int[,] matrix = new int[field[0] + 1, field[1] + 1];
        CreateMatrix(field, matrix);
        Console.WriteLine();
        ConsoleWriteMatrix(GetMaximalSumInMatrix(matrix));
    }

    private static void CreateMatrix(int[] field, int[,] matrix)
    {
        for (int i = 0; i <= field[0]; i++)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            for (int j = 0; j <= field[1]; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }
    }

    private static int[,] GetMaximalSumInMatrix(int[,] matrix)
    {
        int[,] matrixMaxSum = new int[3,3];
        int sum = Int32.MinValue;
        for (int i = 0; i < matrix.GetLength(0)-2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-2; j++)
            {
                int tmp = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] 
                        + matrix[i + 1,j] + matrix[i + 1,j + 1] + matrix[i + 1,j + 2]
                        + matrix[i + 2,j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (tmp > sum)
                {
                    sum = tmp;
                    matrixMaxSum[0, 0] = matrix[i, j];
                    matrixMaxSum[0, 1] = matrix[i, j + 1];
                    matrixMaxSum[0, 2] = matrix[i, j + 2];
                    matrixMaxSum[1, 0] = matrix[i + 1, j];
                    matrixMaxSum[1, 1] = matrix[i + 1, j + 1];
                    matrixMaxSum[1, 2] = matrix[i + 1, j + 2];
                    matrixMaxSum[2, 0] = matrix[i + 2, j];
                    matrixMaxSum[2, 1] = matrix[i + 2, j + 1];
                    matrixMaxSum[2, 2] = matrix[i + 2, j + 2];
                }
            }
        }
        Console.WriteLine("   Sum = {0}", sum);
        return matrixMaxSum;
    }

    private static void ConsoleWriteMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}