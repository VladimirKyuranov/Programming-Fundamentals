using System;
using System.Collections.Generic;

class MinerTask
{
    static void Main(string[] args)
    {
        string resource = string.Empty;
        double quantity = 0;
        var mineStatistics = new Dictionary<string, double>();

        string input;

        while ((input = Console.ReadLine()) != "stop")
        {
            resource = input;
            quantity = double.Parse(Console.ReadLine());

            if (mineStatistics.ContainsKey(resource) == false)
            {
                mineStatistics.Add(resource, 0);
            }

            mineStatistics[resource] += quantity;
        }

        foreach (var entry in mineStatistics)
        {
            Console.WriteLine($"{entry.Key} -> {entry.Value}");
        }
    }
}