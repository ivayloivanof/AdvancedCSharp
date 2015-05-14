using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class ActivityTracker
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, SortedDictionary<string, double>> list = new SortedDictionary<int, SortedDictionary<string, double>>();
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split();
                int month=Month(input[0]);
                string name = input[1];
                double distance = double.Parse(input[2]);

                if (!list.ContainsKey(month))
                {
                    list[month] = new SortedDictionary<string, double>();
                }
                if (!list[month].ContainsKey(name))
                {
                   list[month][name] = distance;
                }
                else if (list[month].ContainsKey(name))
                {
                    list[month][name] += distance;
                }
                
                
            }
            foreach (var month in list)
            {
                string output=null;
                Console.Write("{0}:", month.Key);
                foreach (var name in month.Value)
                {

                    output += " " + name.Key + "(" + name.Value + ")" + ",";
                    
                }
                output = output.TrimEnd(',');
                Console.Write(output);
                Console.WriteLine();
            }

        }
        static int Month (string m)
        {
            int month;
            string currentmonth = m;
            if (currentmonth[3] == '0')
            {
                currentmonth = currentmonth[4].ToString();

            }
            else currentmonth = currentmonth[3].ToString() + currentmonth[4].ToString();
            month = int.Parse(currentmonth);
            return month;
        }
    }
}
