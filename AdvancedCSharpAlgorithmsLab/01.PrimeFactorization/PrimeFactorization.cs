using System;
using System.Collections.Generic;

class PrimeFactorization
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        List<long> prime = new List<long>();
        List<long> primeExit = new List<long>();
        long numbers = number;

        for (int i = 0; i < 3500000; i++)
        {
            if(IsPrime(i))
                prime.Add(i);
        }
        
        if (IsPrime(number))
            Console.WriteLine("{0} = {0}", number);
        else
        {
            bool loop = true;
            int l = 0;
            while (loop)
            {
                //numbers = numbers/prime;
                if (numbers%prime[l] == 0)
                {
                    primeExit.Add(prime[l]);
                    numbers = numbers/prime[l];
                    l = 0;
                }
                else
                    l++;

                if (numbers == 1)
                    loop = false;
            }
            Console.WriteLine("{0} = {1}", number, string.Join(" * ", primeExit.ToArray()));
        }
        
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