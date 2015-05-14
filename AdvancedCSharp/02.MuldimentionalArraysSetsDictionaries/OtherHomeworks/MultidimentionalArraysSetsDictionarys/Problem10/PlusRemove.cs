using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class PlusRemove
    {

        static void Main()
        {
            
            List<string> rows = new List<string>();
            List<string> readyMatrix = new List<string>();

            // inputs the lines
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                    rows.Add(input);
                    readyMatrix.Add(input);
                
            }

            
            for (int i = 0; i < rows.Count - 2; i++)
            {
                string first = rows[i];
                string second = rows[i + 1];
                string third = rows[i + 2];
                int length1 = first.Length;
                int length2 = second.Length;
                int length3 = third.Length;

                // check for plus
                for (int j = 1; j < Math.Min(Math.Min(length1, length2), length3) && j < length2 - 1; j++)
                {
                    var plus = CheckForPlus(j, first, second, third);

                    if (plus)
                    {
                        UpdateFinals(readyMatrix, i, j);
                    }
                }
            }

            // print
            PrintFinals(readyMatrix);
        }

        private static void PrintFinals(List<string> finals)
        {
            for (int i = 0; i < finals.Count; i++)
            {
                finals[i] = finals[i].Replace("К", "");
                Console.WriteLine(finals[i]);
            }
        }

        private static void UpdateFinals(List<string> finals, int i, int j)
        {
            finals[i] = finals[i].Remove(j, 1).Insert(j, "К");
            finals[i + 1] = finals[i + 1].Remove(j - 1, 3).Insert(j - 1, new string('К', 3));
            finals[i + 2] = finals[i + 2].Remove(j, 1).Insert(j, "К");
        }

        private static bool CheckForPlus(int j, string first, string second, string third)
        {
            string up = first.Substring(j, 1).ToLower();
            string match = new string(up[0], 3);
            string middle = second.Substring(j - 1, 3).ToLower();
            string down = third.Substring(j, 1).ToLower();
            bool plus = up == down && match == middle;
            return plus;
        }
    }
}
    
