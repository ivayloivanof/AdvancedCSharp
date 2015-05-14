using System;
using System.Collections.Generic;
using System.Linq;
class StringMatrixRotation
{
    static void Main()
    {
        var rotation = Console.ReadLine().Split(new char[] { '(', ')' });
        int degrees = int.Parse(rotation[1]);
        degrees = degrees % 360;
        List<string> inputList = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            inputList.Add(input);
        }
        int lenght = inputList.Max(s => s.Length);
        char[,] matrix = new char[inputList.Count, lenght];
        for (int row = 0; row < inputList.Count; row++)
        {
            for (int col = 0; col < inputList[row].Length; col++)
            {
                matrix[row, col] = inputList[row][col];
            }
        }
        if (degrees == 180)
        {
            matrix = Degrees180(matrix);
        }
        else if (degrees == 90)
        {
            matrix = Degrees90(matrix);
        }
        else if(degrees == 270)
        {
            matrix = Degrees90(matrix);
            matrix = Degrees180(matrix);
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
    }

    private static char[,] Degrees90(char[,] matrix)
    {
        char[,] copyMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
        int copyCol = copyMatrix.GetLength(1) - 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int copyRow = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                copyMatrix[copyRow, copyCol] = matrix[row, col];
                copyRow++;
            }
            copyCol--;
        }
        matrix = copyMatrix;
        return matrix;
    }

    private static char[,] Degrees180(char[,] matrix)
    {
        int copyRow = matrix.GetLength(0) - 1;
        for (int row = 0; row < matrix.GetLength(0) / 2; row++)
        {
            int copyCol = matrix.GetLength(1) - 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                char swap = matrix[row, col];
                matrix[row, col] = matrix[copyRow, copyCol];
                matrix[copyRow, copyCol] = swap;
                copyCol--;
            }
            copyRow--;
        }
        if (matrix.GetLength(0) % 2 == 1)
        {
            int copyCol = matrix.GetLength(1) - 1;
            for (int col = 0; col < matrix.GetLength(1) / 2; col++)
            {
                char swap = matrix[copyRow, col];
                matrix[copyRow, col] = matrix[copyRow, copyCol - col];
                matrix[copyRow, copyCol - col] = swap;
                copyCol--;
            }
        }
        return matrix;
    }
}
