using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(double.Parse(ReverseDouble(number)));
    }
    static string ReverseDouble (string number)
    {
        char[] charArray = number.ToCharArray();
        Array.Reverse(charArray);
        return new string (charArray);
    }
}

