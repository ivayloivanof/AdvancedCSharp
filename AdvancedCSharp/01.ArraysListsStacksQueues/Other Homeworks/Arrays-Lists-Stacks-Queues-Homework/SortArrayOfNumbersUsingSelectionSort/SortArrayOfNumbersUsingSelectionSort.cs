//Problem 2. Sort Array of Numbers Using Selection Sort
//Write a program to sort an array of numbers and then print them back on the console. 
//The numbers should be entered from the console on a single line, separated by a space. 
//Refer to the examples for problem 1.
//Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
//Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfNumbersUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int[] arr = numbers.Split(' ').Select(int.Parse).ToArray();

            int min = 0;
            int temp = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            for (int k = 0; k < arr.Length ; k++)
            {
                Console.Write("{0} ", arr[k]);
            }
            Console.WriteLine();
        }
    }
}
