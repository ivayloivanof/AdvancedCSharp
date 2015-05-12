using System;
using System.Linq;

    class SortArrayNums
    {
        static void Main()
        {
            string inputNums = Console.ReadLine();
            int[] nums = inputNums.Split(' ').Select(int.Parse).ToArray();
            int zero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
              for (int j = 0; j < nums.Length - 1; j ++)
              {
                 if (nums[j] > nums[j+1])
                 {
                     zero = nums[j + 1];
                     nums[j + 1] = nums[j];
                     nums[j] = zero;
                 }
              }
            }
            foreach (var num in nums)
                Console.Write(num + " ");

        }
    }

