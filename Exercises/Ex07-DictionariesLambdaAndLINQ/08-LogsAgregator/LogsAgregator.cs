using System;
using System.Collections.Generic;
using System.Linq;

class LogsAgregator
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        var ips = new Dictionary<string, List<string>>();
        var times = new Dictionary<string, List<int>>();

        for (int line = 0; line < lines; line++)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string ip = input[0];
            string name = input[1];
            int time = int.Parse(input[2]);

            if (ips.ContainsKey(name) == false)
            {
                ips.Add(name, new List<string>());
                times.Add(name, new List<int>());
            }

            ips[name].Add(ip);
            times[name].Add(time);
        }

        foreach (var user in ips.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{user.Key}: {times[user.Key].Sum()} [{string.Join(", ",user.Value.Distinct().OrderBy(x => x))}]");
        }
    }
}