//Categorize Numbers and Find Min / Max / Average
//Write a program that reads N floating-point numbers from the console.
//Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) 
//and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with 
//their minimum, maximum, sum and average (rounded to two decimal places). 
//Examples:
// Input	                                Output
// 1.2 -4 5.00 12211 93.003 4 2.2	        [1.2, 93.003, 2.2] -> min: 1.2, max: 93.03, sum: 96.403, avg: 32.13
//                                          [-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00

using System;
using System.Collections.Generic;
using System.Linq;

namespace CategorizeNumbersFindMinMaxAverage
{
    class CategorizeNumbersFindMinMaxAverage
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] num = input.Split().Select(double.Parse).ToArray();
            
            List<double> real = new List<double>();
            List<int> integer = new List<int>();
            
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 1 == 0)
                {
                    integer.Add((int)num[i]);
                }
                else
                {
                    real.Add(num[i]);
                }
            }

            Console.WriteLine();
            Console.Write("[ ");
            real.ForEach(a => Console.Write(a + " "));
            Console.Write("] -> min:{0}, ", real.Min());
            Console.Write("max:{0}, ", real.Max());
            Console.Write("sum:{0}, ", real.Sum());
            Console.Write("avg:{0:F2} ", real.Average());
            Console.WriteLine();
            
            Console.WriteLine();
            Console.Write("[ ");
            integer.ForEach(b => Console.Write(b + " "));
            Console.Write("] -> min:{0}, ", integer.Min());
            Console.Write("max:{0}, ", integer.Max());
            Console.Write("sum:{0}, ", integer.Sum());
            Console.Write("avg:{0:F2} ", integer.Average());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
