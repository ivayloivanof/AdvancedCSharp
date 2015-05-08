using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        List<string> sequence = new List<string>();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            string seq = numbers[i].ToString();
            for (int j = i+1; j < numbers.Length; j++)
            {
                int tmp = numbers[j-1];
                if (numbers[j] > tmp)
                {
                    seq += " " + numbers[j];
                    if (j == numbers.Length - 1)
                    {
                        i = j;
                        break;
                    }
                }
                else
                {
                    i = j-1;
                    break;
                }
            }
            sequence.Add(seq.Trim());
        }
        
        int sequenceLongest = 0;
        int loop = 0;

        for (int i = 0; i < sequence.Count; i++)
        {
            Console.WriteLine(sequence[i]);
            int[] nums = sequence[i].Split(' ').Select(x => int.Parse(x)).ToArray<int>();
            int longest = nums.Length;
            if (sequenceLongest < longest)
            {
                sequenceLongest = longest;
                loop = i;
            }

        }
        Console.WriteLine("Longest: {0}", sequence[loop]);
    }
}