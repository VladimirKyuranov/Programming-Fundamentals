using System;
using System.Collections.Generic;
using System.Linq;

class SerbianUnleashed
{
    static void Main(string[] args)
    {
        var serbian = new Dictionary<string, Dictionary<string, int>>();

		string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input
                .Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string singer = tokens[0];
				
            string[] partyInfo = tokens[1]
                .Split()
                .ToArray();
            string venue = string.Empty;
            int money = 1;
            int count = 0;

            foreach (var location in partyInfo)
            {
                try
                {
                    int helper = int.Parse(location);
                    money *= helper;
                    count++;
                }
                catch (Exception)
                {
                    venue += location + " ";
                }
            }

            if (singer.EndsWith(' ') == false || venue.EndsWith(' ') == false || count != 2)
            {
                continue;
            }

            if (serbian.ContainsKey(venue) == false)
            {
                serbian.Add(venue, new Dictionary<string, int>());
            }

            if (serbian[venue].ContainsKey(singer) == false)
            {
                serbian[venue].Add(singer, 0);
            }

            serbian[venue][singer] += money;
        }

        foreach (var venue in serbian)
        {
            Console.WriteLine(venue.Key.Trim());

            foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
            }
        }
    }
}