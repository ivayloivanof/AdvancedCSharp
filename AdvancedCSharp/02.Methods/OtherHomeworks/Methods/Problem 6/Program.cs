using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalc_6
{
    class NumberCalc_6
    {
        static dynamic GetMin(dynamic[] arr)
        {
            dynamic minValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (minValue > arr[i])
                {
                    minValue = arr[i];
                }
            }
            return minValue;
        }
        static dynamic GetMax(dynamic[] arr)
        {
            dynamic maxValue = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }
        static dynamic GetSum(dynamic[] arr)
        {
            dynamic sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static dynamic GetProduct(dynamic[] arr)
        {
            dynamic product = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static dynamic GetAverage(dynamic[] arr)
        {
            dynamic sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            sum = sum / arr.Length;
            return sum;
        }
        static void Main(string[] args)
        {
            dynamic[] doubleArr = { 1.1, 2.2, 0.3, 1.4, 6.5, 6.6, 1.7, 8.8, 0.9 };
            dynamic[] intArr = { 1, 2, 31, 4, 15, 6, 17, 18, 9 };
            Console.WriteLine("Min member -> double {0}  integer {1}", GetMin(doubleArr), GetMin(intArr));
            Console.WriteLine("Max member -> double {0}  integer {1}", GetMax(doubleArr), GetMax(intArr));
            Console.WriteLine("Sum of elements -> double {0}  integer {1}", GetSum(doubleArr), GetSum(intArr));
            Console.WriteLine("Products of elements -> double {0}  integer {1}", GetProduct(doubleArr), GetProduct(intArr));
            Console.WriteLine("Avarage -> double {0}  integer {1}", GetAverage(doubleArr), GetAverage(intArr));

        }
    }
}