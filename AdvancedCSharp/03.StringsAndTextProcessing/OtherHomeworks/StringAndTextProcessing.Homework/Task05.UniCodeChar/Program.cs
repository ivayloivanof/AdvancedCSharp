using System;

namespace Task05.UniCodeChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chArr = Console.ReadLine().ToCharArray();
            foreach (var letter in chArr)
            {
                int value = Convert.ToInt32(letter);
                Console.Write("\\u" + "{0:X4}", value);
            }
        }
    }
}
