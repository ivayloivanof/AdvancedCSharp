using System;
using System.Collections.Generic;
using System.Linq;
class SequenceInMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row,col] = Console.ReadLine();
            }
        }
        List<string> words = new List<string>();
        List<int> sums = new List<int>();
        // Search rows
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                if (col == 0)
                {
                    words.Add(matrix[row, col]);
                    sums.Add(1);
                }
                else if (matrix[row, col] == matrix[row, col - 1])
                {
                    sums[sums.Count - 1]++;
                }
                else
                {
                    words.Add(matrix[row, col]);
                    sums.Add(1);
                }
            }
        }
        // Search columns
        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n; row++)
            {
                if (row == 0)
                {
                    words.Add(matrix[row, col]);
                    sums.Add(1);
                }
                else if (matrix[row, col] == matrix[row - 1, col])
                {
                    sums[sums.Count - 1]++;
                }
                else
                {
                    words.Add(matrix[row, col]);
                    sums.Add(1);
                }
            }
        }
        // Search diagonals
        
        for (int col = 1; col < m - 1; col++)
        {
            words.Add(matrix[col - 1, 0]);
            sums.Add(1);
            if (matrix[col, col] == matrix[col - 1, col - 1])
            {
                sums[sums.Count - 1]++;
            }
            else
            {
                words.Add(matrix[col, col]);
                sums.Add(1);
            }
         }
        int max = sums.Max();
        int index = sums.IndexOf(max);
        for (int i = 0; i < max; i++)
        {
            Console.Write("{0} ", words[index]);
        }
        Console.WriteLine();
    }
}

