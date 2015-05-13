using System;
using System.Collections.Generic;

class TheSieveOfErathosthenes
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<long> prime = new List<long>();

        for (int i = 0; i <= number; i++)
        {
            if (IsPrime(i))
                prime.Add(i);
        }
        Console.WriteLine(String.Join(", ", prime));
    }

    public static bool IsPrime(int candidate)
    {
        // Test whether the parameter is a prime number.
        if ((candidate & 1) == 0)
        {
            if (candidate == 2)
                return true;
            else
                return false;
        }
        for (int i = 3; (i * i) <= candidate; i += 2)
        {
            if ((candidate % i) == 0)
                return false;
        }
        return candidate != 1;
    }
}