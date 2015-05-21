using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class LittleJohn
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}", Console.ReadLine());
        }
        string arrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrowMatcher = new Regex(arrowPattern);
        MatchCollection arrows = arrowMatcher.Matches(sb.ToString());

        int smallArrowCount = 0;
        int mediumArrowCount = 0;
        int largeArrowCount = 0;

        foreach (Match arrow in arrows)
        {
            if (!String.IsNullOrEmpty(arrow.Groups[1].Value))
                largeArrowCount++;
            if (!String.IsNullOrEmpty(arrow.Groups[2].Value))
                mediumArrowCount++;
            if (!String.IsNullOrEmpty(arrow.Groups[3].Value))
                smallArrowCount++;
        }

        string numberAsString = string.Format("{0}{1}{2}", smallArrowCount, mediumArrowCount, largeArrowCount);
        long number = long.Parse(numberAsString);
        string binaryNum = Convert.ToString(number, 2);
        string reverseBinaryNum = new string(binaryNum.Reverse().ToArray());
        string resultAsString = binaryNum + reverseBinaryNum;
        long result = Convert.ToInt64(resultAsString, 2);
        
        Console.WriteLine(result);
    }
}