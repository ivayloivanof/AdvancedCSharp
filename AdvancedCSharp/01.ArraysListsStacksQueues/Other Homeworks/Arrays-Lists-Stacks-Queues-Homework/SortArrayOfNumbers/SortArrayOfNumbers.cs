//Write a program to read an array of numbers from the console, sort them and print them back on the console. 
//The numbers should be entered from the console on a single line, separated by a space. 
//Examples:
// Input	                Output
// 6 5 4 10 -3 120 4	    -3 4 4 5 6 10 120
// 10 9 8	                8 9 10

using System;
using System.Linq;

namespace SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int[] numbers = input.Split().Select(int.Parse).ToArray();
            
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
