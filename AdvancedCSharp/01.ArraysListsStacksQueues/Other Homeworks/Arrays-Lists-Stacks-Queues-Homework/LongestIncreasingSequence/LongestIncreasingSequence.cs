//Longest Increasing Sequence
//Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, 
//separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. 
//Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. 
//If several sequences have the same longest length, print the left-most of them. 
//Examples:
// Input	                       Output
// 2 3 4 1 50 2 3 4 5	           2 3 4
//                                 1 50
//                                 2 3 4 5
//                                 Longest: 2 3 4 5

// 8 9 9 9 -1 5 2 3	               8 9
//                                 9
//                                 9
//                                 -1 5
//                                 2 3
//                                 Longest: 8 9

// 1 2 3 4 5 6 7 8 9	           1 2 3 4 5 6 7 8 9
//                                 Longest: 1 2 3 4 5 6 7 8 9

// 5 -1 10 20 3 4	               5
//                                 -1 10 20
//                                 3 4
//                                 Longest: -1 10 20

// 10 9 8 7 6 5 4 3 2 1	           10
//                                 9
//                                 8
//                                 7
//                                 6
//                                 5
//                                 4
//                                 3
//                                 2 
//                                 1
//                                 Longest: 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] num = input.Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxLenght = 1;
            int end = 0;

            Console.Write(input[0] + " ");
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > num[i - 1])
                {
                    counter++;
                    Console.Write(num[i] + " ");
                }
                else
                {
                    counter = 1;
                    Console.WriteLine();
                    Console.Write(num[i] + " ");
                }
                if (counter > maxLenght)
                {
                    maxLenght = counter;
                    end = i;
                }
            }
            Console.WriteLine();
            Console.Write("Longest: ");
            for (int j = end - maxLenght + 1; j <= end; j++)
            {
                Console.Write(num[j] + " ");
            }
        }
    }
}
