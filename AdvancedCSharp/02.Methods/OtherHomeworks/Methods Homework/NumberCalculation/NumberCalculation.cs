using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculation
{
    class NumberCalculation
    {
        static void Main(string[] args)
        {
            double[] number = { 2, 2, 2, 2, 2, 2 };

            Console.WriteLine("Man = {0}", Maximum(number));
            Console.WriteLine("Min = {0}", Minimun(number));
            Console.WriteLine("Sum = {0}", Sum(number));
            Console.WriteLine("Product = {0}", Product(number));
            Console.WriteLine("Average = {0}", Average(number));
        }
        // Integer Average 
        static int Average(int[] number)
        {
            int average = 0;

            for (int i = 0; i < number.Length; i++)
            {
                average += number[i];
            }
            average /= number.Length;
            return average;
        }
        // Double Average
        static double Average(double[] number)
        {
            double average = 0;

            for (int i = 0; i < number.Length; i++)
            {
                average += number[i];
            }
            average /= number.Length;
            return average;
        }
        // Integer Product
        static int Product(int[] number)
        {
            int product = 1;
            for (int i = 0; i < number.Length; i++)
            {
                product *= number[i];
            }
            return product;
        }

        // Double Product
        static double Product(double[] number)
        {
            double product = 1;
            for (int i = 0; i < number.Length; i++)
            {
                product *= number[i];
            }
            return product;
        }
        // Double Sum 
        static double Sum(double[] number)
        {
            double sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
        // Integer Sum
        static int Sum(int[] number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }
            return sum;
        }
        // Double Minimum
        static double Minimun(double[] numbers)
        {
            double min = double.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];

                }
            }
            return min;
        }
        // Integer Minimum
        static int Minimun(int[] numbers)
        {
            int min = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];

                }
            }
            return min;
        }
        // Double Maximum
        static double Maximum(double[] numbers)
        {
            double max = double.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
        // Integer Maximum
        static int Maximum(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

    }
}
