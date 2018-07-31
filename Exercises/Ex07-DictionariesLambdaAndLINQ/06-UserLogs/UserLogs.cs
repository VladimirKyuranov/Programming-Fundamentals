using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main(string[] args)
    {
        var logs = new SortedDictionary<string, Dictionary<string, int>>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] inputArr = input
                .Split()
                .ToArray();

            string ip = inputArr.First().Remove(0, 3);
            string user = inputArr.Last().Remove(0, 5);

            if (logs.ContainsKey(user) == false)
            {
                logs.Add(user, new Dictionary<string, int>());
            }

            if (logs[user].ContainsKey(ip) == false)
            {
                logs[user].Add(ip, 0);
            }

            logs[user][ip]++;
        }

        foreach (var user in logs)
        {
            Console.WriteLine($"{user.Key}:");
            string ips = string.Empty;

            foreach (var ip in user.Value)
            {
                ips += $"{ip.Key} => {ip.Value}, ";
            }

            ips = ips.Remove(ips.Length - 2) + ".";
            Console.WriteLine(ips);
        }
    }
}