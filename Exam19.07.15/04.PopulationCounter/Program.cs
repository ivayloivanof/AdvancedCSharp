namespace _04.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            const string SplitPattern = @"\|";
            var regex = new Regex(SplitPattern);

            var data = new Dictionary<string, Dictionary<string, long>>();

            string readLine = Console.ReadLine();
            var inputLine = 1;

            while (inputLine <= 50 && readLine != "report")
            {
                string[] tokens = regex.Split(readLine.Trim());
                string city = Regex.Replace(tokens[0].Trim(), @"\s+", " ");
                string country = Regex.Replace(tokens[1].Trim(), @"\s+", " ");
                long population = int.Parse(Regex.Replace(tokens[2].Trim(), @"\s+", " "));

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, long>());
                }

                data[country].Add(city, population);

                readLine = Console.ReadLine();
                inputLine++;
            }

            var result = data.OrderByDescending(x => x.Value.Values.Sum());

            var sb = new StringBuilder();

            foreach (var country in result)
            {
                sb.Append(string.Format("{0} (total population: ", country.Key));
                sb.AppendLine(string.Format("{0})", country.Value.Values.Sum()));

                var newData = country.Value.OrderByDescending(x => x.Value);

                foreach (KeyValuePair<string, long> keyValuePair in newData)
                {
                    sb.AppendLine(string.Format("=>{0}: {1}", keyValuePair.Key, keyValuePair.Value));
                }
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}
