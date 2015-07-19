namespace PlusRemove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string line;
            var chars = new List<string>();
            int loop = 0;
            do
            {
                line = Console.ReadLine();
                if (line.Length > 1 && line.Length <= 100)
                {
                    chars.Add(line);
                }

                if (loop >= 100)
                {
                    break;
                }

                loop++;
            }
            while (!string.IsNullOrEmpty(line) && !line.Contains("END"));

            // create 2 jagged array
            var jaggetArray = new char[chars.Count][];

            for (var row = 0; row < chars.Count; row++)
            {
                var charArr = chars[row].ToLower().ToCharArray();
                jaggetArray[row] = charArr;
            }

            List<string> coordinate = new List<string>();
            for (int row = 1; row < jaggetArray.Length - 2; row++)
            {
                for (int col = 1; col < jaggetArray[row].Length - 1; col++)
                {
                    try
                    {
                        bool isPlus = (jaggetArray[row][col] == jaggetArray[row][col - 1]) && // before char
                                  (jaggetArray[row][col] == jaggetArray[row][col + 1]) && // next char
                                  (jaggetArray[row][col] == jaggetArray[row - 1][col]) && // up char
                                  (jaggetArray[row][col] == jaggetArray[row + 1][col]);
                        if (isPlus)
                        {
                            coordinate.Add(string.Format("{0}, {1}", row, col));
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        continue;
                    }
                }
            }

            for (int row = 0; row < jaggetArray.Length - 1; row++)
            {
                for (int col = 0; col < jaggetArray[row].Length; col++)
                {
                    foreach (string str in coordinate)
                    {
                        int[] numbers = str.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
                        if (row == numbers[0] && col == numbers[1])
                        {
                            jaggetArray[row][col] = '€';
                            jaggetArray[row][col - 1] = '€';
                            jaggetArray[row][col + 1] = '€';
                            jaggetArray[row - 1][col] = '€';
                            jaggetArray[row + 1][col] = '€';
                        }
                    }
                }
            }

            for (int row = 0; row < jaggetArray.Length - 1; row++)
            {
                for (int col = 0; col < jaggetArray[row].Length; col++)
                {
                    if (jaggetArray[row][col] != '€')
                    {
                        Console.Write(jaggetArray[row][col]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
