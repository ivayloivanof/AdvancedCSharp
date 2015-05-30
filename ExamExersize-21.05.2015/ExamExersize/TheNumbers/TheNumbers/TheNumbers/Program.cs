using System;
using System.Collections.Generic;
using System.Text;

namespace TheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineText = Console.ReadLine();
            char[] line = lineText.ToCharArray();
            List<int> numbers = new List<int>();

            for (int i = 0; i < line.Length; i++)
            {
                StringBuilder num = new StringBuilder();
                while (true)
                {
                    if (i < line.Length && line[i] >= 48 && line[i] <= 57)
                    {
                        num.Append(line[i]);
                    }
                    else
                    {
                        try
                        {
                            numbers.Add(int.Parse(num.ToString()));
                            break;
                        }
                        catch (FormatException ex)
                        {
                            break;
                        }
                    }
                    i++;
                }
            }

            List<string> hexNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string numHex = "0x"+numbers[i].ToString("X").PadLeft(4, '0');
                hexNumbers.Add(numHex);
             }

            Console.WriteLine(String.Join("-", hexNumbers));
        }
    }
}
