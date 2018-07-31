using System;
using System.Collections.Generic;
using System.Linq;

class AnonymousCache
{
    static void Main(string[] args)
    {
        string input;
        var dataSets = new Dictionary<string, Dictionary<string, long>>();
        var cache = new Dictionary<string, Dictionary<string, long>>();

        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            string[] data = input
                .Split(" ->|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string dataSet = string.Empty;
            string dataKey = string.Empty;
            long dataSize = 0;

            if (data.Length == 1)
            {
                dataSet = data[0];
                if (dataSets.ContainsKey(dataSet) == false)
                {
                    dataSets.Add(dataSet, new Dictionary<string, long>());
                }

                if (cache.ContainsKey(dataSet))
                {
                    foreach (var set in cache[dataSet])
                    {
                        dataSets[dataSet].Add(set.Key, set.Value);
                    }

                    cache.Remove(dataSet);
                }
            }
            else
            {
                dataSet = data[2];
                dataKey = data[0];
                dataSize = long.Parse(data[1]);

                if (dataSets.ContainsKey(dataSet))
                {
                    dataSets[dataSet].Add(dataKey, dataSize);
                }
                else
                {
                    if (cache.ContainsKey(dataSet) == false)
                    {
                        cache.Add(dataSet, new Dictionary<string, long>());
                    }

                    cache[dataSet].Add(dataKey, dataSize);
                }
            }
        }

        if (dataSets.Count > 0)
        {
            string bestDataSet = string.Empty;
            long maxSum = long.MinValue;

            foreach (var pair in dataSets)
            {
                long sum = pair.Value.Values.Sum();

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestDataSet = pair.Key;
                }
            }

            Console.WriteLine($"Data Set: {bestDataSet}, Total Size: {maxSum}");

            foreach (var pair in dataSets[bestDataSet])
            {
                Console.WriteLine($"$.{pair.Key}");
            }
        }
    }
}