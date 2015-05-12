using System;
using System.Linq;


    class SortArrayOfNumbers
    {
        static void Main()
        {
            string inputNums = Console.ReadLine();
            int[] nums = inputNums.Split(' ').Select(int.Parse).ToArray();
            Array.Sort(nums);
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
