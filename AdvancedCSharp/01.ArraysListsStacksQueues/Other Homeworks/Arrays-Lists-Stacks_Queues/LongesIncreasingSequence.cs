using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] inputString = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[] stringList = new string[inputString.Length];
        int[] stringListLengths = new int[inputString.Length];
        int counter = 0;

        for (int i = 0; i < inputString.Length - 1; i++)
        {
            if (inputString[i] < inputString[i + 1])
            {
                stringList[counter] += inputString[i].ToString() + " ";
                stringListLengths[counter]++;
            }
            else
            {
                stringList[counter] += inputString[i].ToString() + " ";
                stringListLengths[counter]++;
                counter++;
            }
        }
        stringList[counter] += inputString[inputString.Length - 1] + " ";
        stringListLengths[counter]++;

        int maxElement = stringListLengths[0];
        int maxElementPos = 0;

        for (int i = 0; i <= counter; i++)
        {
            Console.WriteLine(stringList[i]);
            if (stringListLengths[i] > maxElement)
            {
                maxElement = stringListLengths[i];
                maxElementPos = i;
            }
        }

        
        Console.WriteLine("Longest: {0}", stringList[maxElementPos]);


    }
}

