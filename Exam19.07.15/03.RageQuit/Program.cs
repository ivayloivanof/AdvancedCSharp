namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Trim().ToCharArray();

            StringBuilder result = new StringBuilder();
            SortedSet<string> uniqueSymbols = new SortedSet<string>();
            string chars = null;

            for (int loop = 0; loop < inputLine.Length; loop++)
            {
                char c = inputLine[loop];

                if (char.IsNumber(c))
                {
                    string num = c.ToString();
                    if ((loop < inputLine.Length - 1) && char.IsNumber(inputLine[loop + 1]))
                    {
                        num += inputLine[loop + 1].ToString();
                        if ((loop < inputLine.Length - 2) && char.IsNumber(inputLine[loop + 2]))
                        {
                            num += inputLine[loop + 2].ToString();
                        }
                    }

                    var number = int.Parse(num);

                    for (var i = 0; i < number; i++)
                    {
                        if (chars != null)
                        {
                            result.Append(chars.ToUpper());
                        }
                    }

                    chars = null;
                    continue;
                }

                uniqueSymbols.Add(c.ToString().ToUpper());
                chars += c;
            }

            Console.WriteLine("Unique symbols used: {0}", uniqueSymbols.Count == 54 ? uniqueSymbols.Count - 1 : uniqueSymbols.Count);
            Console.WriteLine(result.ToString());
        }
    }
}
