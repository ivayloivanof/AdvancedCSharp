using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int max = GetMax(firstNum, secondNum);
            Console.Clear();
            Console.WriteLine(max);
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            int maxValue = Math.Max(firstNum, secondNum);
            return maxValue;
        }
    }
}
