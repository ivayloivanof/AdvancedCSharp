namespace PlusRemove
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string line;
            List<string> chars = new List<string>();

            do
            {
                line = Console.ReadLine();
                chars.Add(line);
            }
            while (!string.IsNullOrEmpty(line) && !line.Contains("END"));
            Console.WriteLine();
        }
    }
}
