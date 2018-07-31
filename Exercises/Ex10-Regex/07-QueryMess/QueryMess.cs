using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main(string[] args)
    {
        string pattern = @"(?<key>.+)=(?<value>.+)";
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var matches = new Dictionary<string, List<string>>();
            string[] pairs = input
                .Split("?&".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int index = 0; index < pairs.Length; index++)
            {
                pairs[index] = pairs[index].Replace('+', ' ');
                pairs[index] = pairs[index].Replace("%20", " ");
                pairs[index] = Regex.Replace(pairs[index], @"\s+", " ");
            }

            foreach (string pair in pairs)
            {
                if (pair.Contains("="))
                {
                    Match result = Regex.Match(pair, pattern);
                    string key = result.Groups["key"].Value.Trim();
                    string value = result.Groups["value"].Value.Trim();

                    if (matches.ContainsKey(key) == false)
                    {
                        matches.Add(key, new List<string>());
                    }

                    matches[key].Add(value);
                }
            }

            foreach (var pair in matches)
            {
                Console.Write($"{pair.Key}=[{string.Join(", ", pair.Value)}]");
            }

            Console.WriteLine();
        }
    }
}