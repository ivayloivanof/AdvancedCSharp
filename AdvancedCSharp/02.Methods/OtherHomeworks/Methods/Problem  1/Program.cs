using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem__1
{
    class Program
    {
        static int Getmax(int a , int b)
        {
            int c = Math.Max(a, b);
            return c;
        }

        private static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = Getmax(first, second);
            Console.WriteLine(max);
        }
    }
}
