using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex("\\s+");
            List<string> rowResult = new List<string>();
            bool changet = false;

            string[] numbers = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = regex.Replace(numbers[i], " ").Trim();
            }

            while (true)
            {
                List<string> tmpNumber = new List<string>();
                string line = Console.ReadLine();

                if (line.Contains("end"))
                    break;

                string[] commands = line.Split();

                if (line.Contains("reverse from"))
                {
                    int start = int.Parse(commands[2]);
                    int end = int.Parse(commands[4]);

                    if (CheckPositions(start, end, numbers))
                    {
                        for (int i = start; i < start+end; i++)
                        {
                            tmpNumber.Add(numbers[i]);
                        }
                        tmpNumber.Reverse();
                        for (int i = start, j = 0; i < start + end; i++, j++)
                        {
                            numbers[i] = tmpNumber[j];
                        }
                        rowResult.Add(String.Format("[{0}]", String.Join(", ", numbers)));
                        changet = true;
                    }
                    else
                    {
                        rowResult.Add("Invalid input parameters.");
                        continue;
                    }
                }
                else if (line.Contains("sort from"))
                {
                    int start = int.Parse(commands[2]);
                    int end = int.Parse(commands[4]);
                    if (CheckPositions(start, end, numbers))
                    {
                        for (int i = start; i < start + end; i++)
                        {
                            tmpNumber.Add(numbers[i]);
                        }
                        tmpNumber.Sort();
                        for (int i = start, j = 0; i < start + end; i++, j++)
                        {
                            numbers[i] = tmpNumber[j];
                        }
                        rowResult.Add(String.Format("[{0}]", String.Join(", ", numbers)));
                        changet = true;
                    }
                    else
                    {
                        rowResult.Add("Invalid input parameters.");
                        continue;
                    }
                }
                else if (line.Contains("rollLeft"))
                {
                    int times = int.Parse(commands[1]);
                    foreach (string number in numbers)
                    {
                        tmpNumber.Add(number);
                    }
                    for (int i = 0; i < times; i++)
                    {
                        string tmp = tmpNumber[0];
                        tmpNumber.RemoveAt(0);
                        tmpNumber.Insert(tmpNumber.Count, tmp);
                    }
                    rowResult.Add(String.Format("[{0}]", String.Join(", ", tmpNumber)));
                    changet = true;
                }
                else if (line.Contains("rollRight"))
                {
                    int times = int.Parse(commands[1]);
                    foreach (string number in numbers)
                    {
                        tmpNumber.Add(number);
                    }
                    for (int i = 0; i < times; i++)
                    {
                        string tmp = tmpNumber[tmpNumber.Count-1];
                        tmpNumber.RemoveAt(tmpNumber.Count-1);
                        tmpNumber.Insert(0, tmp);
                    }
                    rowResult.Add(String.Format("[{0}]", String.Join(", ", tmpNumber)));
                    changet = true;
                }

            }
            
            foreach (string s in rowResult)
            {
                Console.WriteLine(s);
            }
            if (!changet)
                Console.WriteLine("[{0}]", String.Join(", ", numbers));

        }

        public static bool CheckPositions(int start, int end, string[] numbers)
        {
            bool result = true;
            if (start < 0 || end < 0 || end >= numbers.Length)
                result = false;

            if (start >= end)
                result = false;

            return result;
        }
    }
}
