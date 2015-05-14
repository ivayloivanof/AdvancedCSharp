using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class NightLife
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> Dictionary =
                            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;

                string[] command = input.Split(';');
                string city = command[0];
                string venue = command[1];
                string singer = command[2];

                if (!Dictionary.ContainsKey(city))
                {
                    Dictionary[city] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!Dictionary[city].ContainsKey(venue))
                {
                    Dictionary[city][venue] = new SortedSet<string>();
                }
                    Dictionary[city][venue].Add(singer);


                
            }
            foreach (var city in Dictionary)
                {
                    Console.WriteLine("{0}", city.Key);
                    foreach (var venue in city.Value)
                    {
                        Console.Write("->"+venue.Key+":");
                        foreach(var singer in venue.Value)
                        {
                            Console.Write(" ");
                                Console.WriteLine(string.Join(", ",venue.Value));;
                        }
                    }
                }

        }  
        
    }
}
