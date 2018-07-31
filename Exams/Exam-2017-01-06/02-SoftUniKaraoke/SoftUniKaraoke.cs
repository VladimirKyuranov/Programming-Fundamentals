using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniKaraoke
{
    static void Main(string[] args)
    {
        string[] participants = Console.ReadLine()
            .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        string[] songs = Console.ReadLine()
            .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();
        string input;

        var awards = new Dictionary<string, List<string>>();

        while ((input = Console.ReadLine()) != "dawn")
        {
            string[] performance = input
            .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(x => x.Trim())
            .ToArray();

            string participant = performance[0];
            string song = performance[1];
            string award = performance[2];

            if (participants.Contains(participant) == false || songs.Contains(song) == false)
            {
                continue;
            }

            if (awards.ContainsKey(participant) == false)
            {
                awards.Add(participant, new List<string>());
            }

            if (awards[participant].Contains(award) == false)
            {
                awards[participant].Add(award);
            }
        }

        if (awards.Count < 1)
        {
            Console.WriteLine("No awards");
            Environment.Exit(0);
        }

        foreach (var pair in awards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value.Count} awards");

            foreach (var award in pair.Value.OrderBy(x => x))
            {
                Console.WriteLine($"--{award}");
            }
        }
    }
}