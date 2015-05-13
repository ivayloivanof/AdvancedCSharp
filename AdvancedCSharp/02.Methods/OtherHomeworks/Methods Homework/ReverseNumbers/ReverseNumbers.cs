using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            double result = GetRerversedNumber(256);
            Console.WriteLine(result);
        }

        static double GetRerversedNumber(double number)
        {
            List<char> reverseNumber = new List<char>();
            string stringNum = number.ToString();
            for (int i = 0; i < stringNum.Length; i++)
            {
                reverseNumber.Add(stringNum[i]);
            }

            reverseNumber.Reverse();
            StringBuilder buildString = new StringBuilder();
            foreach (var item in reverseNumber)
            {
                buildString.Append(item);
            }
            stringNum = buildString.ToString();
            double result = double.Parse(stringNum);
            return result;
        }
    }
}
