using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem2
{
    class RepalceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?i)<a([^>]+)>(.+?)<\/a>";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                regex = new Regex("<a");
                string result = regex.Replace(match.ToString(), "[URL");

                regex = new Regex(">");
                result = regex.Replace(result, "]");

                regex = new Regex("</a");
                result = regex.Replace(result, "[/URL");
                Console.WriteLine(result);
            }

        }
    }
}
