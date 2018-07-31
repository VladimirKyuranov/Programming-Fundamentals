using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main(string[] args)
    {
        var populationLog = new Dictionary<string, Dictionary<string, long>>();

        string input;

        while((input = Console.ReadLine()) != "report")
        {
            string[] inputArr = input
                .Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string country = inputArr[1];
            string city = inputArr[0];
            long population = long.Parse(inputArr[2]);

            if (populationLog.ContainsKey(country) == false)
            {
                populationLog.Add(country, new Dictionary<string, long>());
            }

            if (populationLog[country].ContainsKey(city) == false)
            {
                populationLog[country].Add(city, population);
            }

            populationLog[country][city] = population;
        }

        foreach (var country in populationLog.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

            foreach (var city in country.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}