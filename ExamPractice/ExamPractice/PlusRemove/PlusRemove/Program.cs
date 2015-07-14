namespace PlusRemove
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string line;
            var chars = new List<string>();
            do
            {
                line = Console.ReadLine();
                chars.Add(line);
            }
            while (!string.IsNullOrEmpty(line) && !line.Contains("END"));

            // create 2 jagged array
            var jaggetArray = new char[chars.Count][];

            for (var row = 0; row < chars.Count; row++)
            {
                var charArr = chars[row].ToLower().ToCharArray();
                jaggetArray[row] = charArr;
            }

            // deep cope
            var jaggedArrayClone = (char[][])jaggetArray.Clone();

            for (int row = 1; row < jaggetArray.Length - 2; row++)
            {
                for (int col = 1; col < jaggetArray[row].Length - 1; col++)
                {
                    bool isPlus = (jaggetArray[row][col] == jaggetArray[row][col - 1]) && // before char
                                  (jaggetArray[row][col] == jaggetArray[row][col + 1]) && // next char
                                  (jaggetArray[row][col] == jaggetArray[row - 1][col]) && // up char
                                  (jaggetArray[row][col] == jaggetArray[row + 1][col]);
                    if (isPlus)
                    {
                        jaggedArrayClone[row][col] = '€';
                        jaggedArrayClone[row][col - 1] = '€';
                        jaggedArrayClone[row][col + 1] = '€';
                        jaggedArrayClone[row - 1][col] = '€';
                        jaggedArrayClone[row + 1][col] = '€';
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Original");
            for (int row = 0; row < jaggetArray.Length; row++)
            {
                for (int col = 0; col < jaggetArray[row].Length; col++)
                {
                    Console.Write(jaggetArray[row][col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Clone;");
            for (int row = 0; row < jaggedArrayClone.Length; row++)
            {
                for (int col = 0; col < jaggedArrayClone[row].Length; col++)
                {
                    Console.Write(jaggedArrayClone[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
