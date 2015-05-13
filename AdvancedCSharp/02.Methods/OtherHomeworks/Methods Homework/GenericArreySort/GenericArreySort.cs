using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArreySort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 2, 16, 24, 5, 1, 27, 80, 9 };
            List<string> words = new List<string> { "baa", "omo", "zaz", "cba", "azis" };
            List<DateTime> dates = new List<DateTime> { new DateTime(2012, 02, 01) , 
                                                            new DateTime(2015, 05 , 06 ) , new DateTime(1889 , 04 , 05)};

            SortObjectList(numbers);
            SortObjectList(words);
            SortObjectList(dates);
        }

        static void SortObjectList<T>(List<T> obj) where T : IComparable
        {
            while (true)
            {
                bool sorted = true;
                for (int i = 0; i < obj.Count - 1; i++)
                {
                    if (obj[i].CompareTo(obj[i+1]) > 0)
                    {
                        T temp = obj[1];
                        obj[i] = obj[i + 1];
                        obj[i + 1] = temp;
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    foreach (var objects in obj)
                    {
                        Console.Write("{0} ",objects);
                    }
                    Console.WriteLine();
                    return;
                }
            }
        }
    }
}
