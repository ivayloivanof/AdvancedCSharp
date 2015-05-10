using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        int[] field = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        string[,] matrix = new string[field[0] + 1, field[1] + 1];
        CreateMatrix(field, matrix);
        Console.WriteLine();
        ConsoleWriteMatrix(matrix);
    }

    private static string[,] CreateMatrix(int[] field, string[,] matrix)
    {
        for (int i = 0; i <= field[0]; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for (int j = 0; j <= field[1]; j++)
            {
                matrix[i, j] = numbers[j].Trim();
            }
        }
        return matrix;
    }

    private static void ConsoleWriteMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}