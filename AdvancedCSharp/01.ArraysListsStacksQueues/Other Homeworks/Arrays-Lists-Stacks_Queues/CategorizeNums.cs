using System;
using System.Collections.Generic;
using System.Linq;

    class CategorizeNums
    {
        static void Main()
        {
            string inputNums = Console.ReadLine();
            double[] nums = inputNums.Split(' ').Select(double.Parse).ToArray();
            
            List<int> roundedNums = new List<int>();
            List<double> doubleNums = new List<double>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 1 == 0)
                {
                    roundedNums.Add((int)nums[i]);
                }
                else
                {
                    doubleNums.Add(nums[i]);
                }
            }
            
            Console.WriteLine("[{0}]" + " -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", doubleNums.ToArray()), doubleNums.Min(), doubleNums.Max(), doubleNums.Sum(), doubleNums.Average());

            Console.WriteLine("[{0}]" + " -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", roundedNums.ToArray()), roundedNums.Min(), roundedNums.Max(), roundedNums.Sum(), roundedNums.Average());          
        }
    }

