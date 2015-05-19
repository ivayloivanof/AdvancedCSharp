using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem1
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([a-z]){1}\1+";            
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            

            foreach (var match in matches)
            {
                Console.Write(match.ToString()[0]);
            }

            Console.WriteLine();
        }
    }
}
