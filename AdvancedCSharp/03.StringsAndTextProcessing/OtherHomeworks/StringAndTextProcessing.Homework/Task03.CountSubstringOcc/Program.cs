using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Task03.CountSubstringOcc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();
            int m = Regex.Matches(input, search).Count;
            Console.WriteLine(m);
        }
    }
}
