using System;
class PrimeFactorization
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int prime = 2;
        int startNum = number;

        //Console.Write("{0} = ", );
        if (IsPrime(number))
        {
            Console.WriteLine("{0} = {0}", number);
        }
        else
        {
            bool loop = true;
            while (loop)
            {
                number = number/prime;
                if (IsPrime(number))
                {
                    loop = false;
                }
            }
        }
        Console.WriteLine("{0} = {0}", startNum);
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