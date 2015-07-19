namespace StringMatrixRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] strings = line.Split('(');
            int degrees = Convert.ToInt32(strings[1].Replace(')', ' '));
            var rowForMatrix = new List<string>();

            do
            {
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line) && !line.Contains("END") && 
                    line.Length > 1 && line.Length <= 100)
                {
                    rowForMatrix.Add(line);
                }
            }
            while (!string.IsNullOrEmpty(line) && !line.Contains("END"));
            char[,] matrix;

            if (degrees == 0)
            {
                matrix = IntoMatrix0(rowForMatrix);
                PrintMatrix(matrix);
            }
            if (degrees == 90)
            {
                matrix = IntoMatrix90(rowForMatrix);
                PrintMatrix(matrix);
            }
        }

        public static char[,] IntoMatrix0(List<string> rowForMatrix)
        {
            int maxLenght = rowForMatrix.Select(t => t.Length).Concat(new[] { 0 }).Max();
            char[,] matrix = new char[rowForMatrix.Count, maxLenght];

            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            // insert into matrix
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (j < rowForMatrix[i].Length)
                    {
                        matrix[i, j] = rowForMatrix[i][j];
                    }
                }
            }
            return matrix;
        }

        public static char[,] IntoMatrix90(List<string> rowForMatrix)
        {
            int maxLenght = rowForMatrix.Select(t => t.Length).Concat(new[] { 0 }).Max();
            char[,] matrix = new char[rowForMatrix.Count, maxLenght];

            int row = matrix.GetLength(1);
            int col = matrix.GetLength(0);

            for (int i = col - 1, k = 0; i >= 0; i--, k++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i, j] = rowForMatrix[k][j];
                }
            }
            
            return matrix;
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
