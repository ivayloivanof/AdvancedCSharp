using System;
using System.Collections.Generic;
class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        string city = string.Empty;
        string venue = string.Empty;
        string performer = string.Empty;
        while(true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            string[] allData = input.Split(';');
            city = allData[0];
            venue = allData[1];
            performer = allData[2];
            if (!nightLife.ContainsKey(city))
            {
                nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!nightLife[city].ContainsKey(venue))
            {
                nightLife[city][venue] = new SortedSet<string>();
            }
            if (!nightLife[city][venue].Contains(performer))
            {
                nightLife[city][venue].Add(performer);
            }
        }
        foreach (var cityPair in nightLife)
        {
            Console.WriteLine(cityPair.Key);
            foreach (var venuePair in cityPair.Value)
            {
                Console.WriteLine("->{0}: {1}", venuePair.Key, String.Join(", ", venuePair.Value));
            }
        }
    }

}

