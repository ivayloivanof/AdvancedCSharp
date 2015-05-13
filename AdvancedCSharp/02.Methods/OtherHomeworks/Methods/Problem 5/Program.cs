using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNum_5
{
    class ReverseNum_5
    {
        static double ReverseNumber(double num)
        {
            string number = num.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string revNum = new string(reverse);
            double newNum = double.Parse(revNum);

            return newNum;
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine(ReverseNumber(number));
        }
    }
}