using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class CategorizeNumbersAndFindMinMaxAverage
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
        double[] arr = Console.ReadLine().Split(' ').Select(Convert.ToDouble).ToArray();
        //Console.WriteLine(string.Join(", ", arr)); 
        List<double> doubleList = new List<double>();
        List<int> intList = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            double d = arr[i];
            if (Math.Abs(d - (int)d) < double.Epsilon)
            {
                intList.Add((int)d);
            }
            else
            {
                doubleList.Add(d);
            }
        }
        int intMin = intList.Min();
        int intMax = intList.Max();
        double doubleMin = doubleList.Min();
        double doubleMax = doubleList.Max();
        int intSum = intList.Sum();
        double doubleSum = doubleList.Sum();
        double intAverage = intList.Average();
        double doubleAverage = doubleList.Average();
        Console.Write("[");
        Console.Write(string.Join(", ", intList));
        Console.Write("]");
        Console.WriteLine(" - > min: {0}, max: {1},sum: {2}, avg: {3: 0.00}", intMin, intMax, intSum, intAverage);
        Console.Write("[");
        Console.Write(string.Join(", ", doubleList));
        Console.Write("]");
        Console.WriteLine(" - > min: {0}, max: {1},sum: {2}, avg: {3: 0.00}", doubleMin, doubleMax, doubleSum, doubleAverage);
    }
}
