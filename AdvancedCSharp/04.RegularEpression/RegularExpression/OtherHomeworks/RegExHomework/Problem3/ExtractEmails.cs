using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3
{
    class ExtractEmails
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^[\w-]{4,12}@[\w\-]{2,}\.[a-zA-Z]+$";

            Regex regex = new Regex(pattern);
        }
    }
}
