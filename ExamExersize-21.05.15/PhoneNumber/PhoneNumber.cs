using System;
using System.Text.RegularExpressions;

namespace PhoneNumber
{
    class PhoneNumber
    {
        static void Main()
        {
            string pattern = @"([a-zA-Z]+)|([\+\.\/\-\s\(\)]?[0-9]+[\+\.\/\-\(\)]?)";
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Contains("END"))
                    break;

                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(line);


                Console.WriteLine();
            }
            //<b>[name]:</b> [phone number] 
        }
    }
}
