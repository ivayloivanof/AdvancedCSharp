using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Task01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine(reversed);

            /*            
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
             */
        }
    }
}
