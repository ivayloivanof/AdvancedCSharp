using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlusRemove
{
    public static class PlusRemove
    {
        static void Main()
        {
            Dictionary<int, char[]> dictionary = new Dictionary<int, char[]>();
            int rows = 0;
            while (true)
            {
                string row = Console.ReadLine();
                if (row.Contains("END"))
                    break;
                char[] rowChars = row.ToCharArray();
                dictionary.Add(rows, rowChars);
                rows++;
            }

            int rowLenght = int.MinValue;
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (rowLenght < dictionary[i].Length)
                    rowLenght = dictionary[i].Length;
            }

            char[,] matrix = new char[dictionary.Count, rowLenght];

            for (int i = 0; i < dictionary.Count; i++)
            {
                for (int j = 0; j < dictionary[i].Length; j++)
                {
                    matrix[i, j] = dictionary[i][j];
                }
            }
            
            for (int i = 1; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1)-1; j++)
                {

                    char a = matrix[i - 1, j];
                    char b = matrix[i, j - 1];
                    char c = matrix[i, j];
                    char d = matrix[i, j + 1];
                    char e = matrix[i + 1, j];

                    if (Char.IsDigit(c))
                    {
                        if (c == a && c == b && c == d && c == e)
                        {
                            matrix[i - 1, j] = '?';
                            matrix[i, j - 1] = '?';
                            matrix[i, j] = '?';
                            matrix[i, j + 1] = '?';
                            matrix[i + 1, j] = '?';
                        }
                    }
                    else
                    {
                        if (Char.ToLower(c) == Char.ToLower(a) && 
                            Char.ToLower(c) == Char.ToLower(b) &&
                            Char.ToLower(c) == Char.ToLower(d) &&
                            Char.ToLower(c) == Char.ToLower(e))
                        {
                            matrix[i - 1, j] = '?';
                            matrix[i, j - 1] = '?';
                            matrix[i, j] = '?';
                            matrix[i, j + 1] = '?';
                            matrix[i + 1, j] = '?';
                        }
                    }
                }
            }

            

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                StringBuilder str = new StringBuilder();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char field = matrix[i, j];
                    if (field != '?')
                    {
                        str.Append(matrix[i, j]);
                    }
                }
                Console.WriteLine(str.ToString().RemoveWhitespace().Trim());
            }
        }

        public static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
