using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class countSymbols
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            Array.Sort(chars);
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if(dictionary.ContainsKey(chars[i]))
                {
                    dictionary[chars[i]]++;
                }
                else
                {
                    dictionary[chars[i]] = 1;
                }
            }
            foreach(var pair in dictionary)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key,pair.Value);
            }

        }
    }
}
