using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_2.ReplaceATag
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string example = @"<a\s+href=([^>]+)>([^<]+)</a>";
            Regex regex = new Regex(example);
            string replace = "[URL href=$1]$2[/URL]";
            string output = Regex.Replace(input, example, replace);
            Console.WriteLine(output);
        }
    }
}
