using System;
using System.Collections.Generic;

internal class NightLife
{
    private static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLife =
            new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string[] events;
        string city = String.Empty;
        string venue = String.Empty;
        string performer = String.Empty;
        string ivent = Console.ReadLine();

        while (ivent != "END")
        {
            events = ivent.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);

            city = events[0];
            venue = events[1];
            performer = events[2];

            if (!nightLife.ContainsKey(city))
                nightLife[city] = new SortedDictionary<string, SortedSet<string>>();
            if (!nightLife[city].ContainsKey(venue))
                nightLife[city][venue] = new SortedSet<string>();
            nightLife[city][venue].Add(performer);

            ivent = Console.ReadLine();
        }

        foreach (var towns in nightLife)
        {
            Console.WriteLine(towns.Key);
            foreach (var value in towns.Value)
            {
                Console.WriteLine("->{0}: {1}", value.Key, String.Join(", ", value.Value));
            }
        }
    }
}