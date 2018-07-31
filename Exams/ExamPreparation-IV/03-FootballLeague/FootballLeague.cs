using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class FootballLeague
{
    static void Main(string[] args)
    {
        string key = Regex.Escape(Console.ReadLine());

        string game = string.Empty;
        string pattern = $@"{key}(?<country>[a-zA-Z]+){key}";
        var standings = new Dictionary<string, List<long>>();

        while ((game = Console.ReadLine()) != "final")
        {
            string[] gameInfo = game
                .Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Match firstCountryMatch = Regex.Match(gameInfo[0], pattern);
            Match secondCountryMatch = Regex.Match(gameInfo[1], pattern);
            StringBuilder builder = new StringBuilder();
            string firstCountry = firstCountryMatch.Groups["country"].Value;
            string secondCountry = secondCountryMatch.Groups["country"].Value;

            for (int index = firstCountry.Length - 1; index >= 0; index--)
            {
                builder.Append(firstCountry[index]);
            }

            firstCountry = builder.ToString().ToUpper();
            builder = new StringBuilder();

            for (int index = secondCountry.Length - 1; index >= 0; index--)
            {
                builder.Append(secondCountry[index]);
            }

            secondCountry = builder.ToString().ToUpper();

            long firstCountryGoals = long.Parse(gameInfo[2]);
            long secondCountryGoals = long.Parse(gameInfo[3]);
            int firstCountryPoints = 0;
            int secondCountryPoints = 0;

            if (firstCountryGoals > secondCountryGoals)
            {
                firstCountryPoints = 3;
            }
            else if (firstCountryGoals < secondCountryGoals)
            {
                secondCountryPoints = 3;
            }
            else
            {
                firstCountryPoints = 1;
                secondCountryPoints = 1;
            }

            if (standings.ContainsKey(firstCountry) == false)
            {
                standings.Add(firstCountry, new List<long> { 0, 0 });
            }

            standings[firstCountry][0] += firstCountryGoals;
            standings[firstCountry][1] += firstCountryPoints;

            if (standings.ContainsKey(secondCountry) == false)
            {
                standings.Add(secondCountry, new List<long> { 0, 0 });
            }

            standings[secondCountry][0] += secondCountryGoals;
            standings[secondCountry][1] += secondCountryPoints;
        }

        Console.WriteLine("League standings:");

        int place = 1;

        foreach (var country in standings.OrderByDescending(c => c.Value[1]).ThenBy(c => c.Key))
        {
            Console.WriteLine($"{place}. {country.Key} {country.Value[1]}");
            place++;
        }

        Console.WriteLine("Top 3 scored goals:");

        foreach (var country in standings.OrderByDescending(c => c.Value[0]).ThenBy(c => c.Key).Take(3))
        {
            Console.WriteLine($"- {country.Key} -> {country.Value[0]}");
        }
    }
}