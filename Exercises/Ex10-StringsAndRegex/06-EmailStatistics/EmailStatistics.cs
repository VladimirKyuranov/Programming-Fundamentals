using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class EmailStatistics
{
    static void Main(string[] args)
    {
        int emailsCount = int.Parse(Console.ReadLine());

        string pattern = @"^(?<user>[a-zA-Z]{5,})@(?<domain>[a-z]{3,}([.]org|[.]bg|[.]com))$";
        var domains = new Dictionary<string, List<string>>();

        for (int currentEmail = 0; currentEmail < emailsCount; currentEmail++)
        {
            string email = Console.ReadLine();

            Match checkEmail = Regex.Match(email, pattern);

            if (checkEmail.Success)
            {
                string user = checkEmail.Groups["user"].Value;
                string domain = checkEmail.Groups["domain"].Value;

                if (domains.ContainsKey(domain) == false)
                {
                    domains.Add(domain, new List<string>());
                }

                if (domains[domain].Contains(user) == false)
                {
                    domains[domain].Add(user);
                }
            }
        }

        foreach (var pair in domains.OrderByDescending(d => d.Value.Count))
        {
            Console.WriteLine($"{pair.Key}:");

            foreach (string user in pair.Value)
            {
                Console.WriteLine($"### {user}");
            }
        }
    }
}