using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniExamResults
{
    static void Main(string[] args)
    {
        Dictionary<string, int> users = new Dictionary<string, int>();
        Dictionary<string, int> languages = new Dictionary<string, int>();

        string input;

        while ((input = Console.ReadLine()) != "exam finished")
        {
            string[] userArgs = input.Split('-');

            string username = userArgs[0];
            string language = userArgs[1];

            if (language == "banned")
            {
                users.Remove(username);
                continue;
            }

            int points = int.Parse(userArgs[2]);

            if (users.ContainsKey(username) == false)
            {
                users.Add(username, points);
            }

            if (users[username] < points)
            {
                users[username] = points;
            }

            if (languages.ContainsKey(language) == false)
            {
                languages.Add(language, 0);
            }

            languages[language]++;
        }

        Console.WriteLine("Results:");

        foreach (var user in users
            .OrderByDescending(u => u.Value)
            .ThenBy(u => u.Key))
        {
            string result = $"{user.Key} | {user.Value}";
            Console.WriteLine(result);
        }

        Console.WriteLine("Submissions:");

        foreach (var language in languages
            .OrderByDescending(l => l.Value)
            .ThenBy(l => l.Key))
        {
            string result = $"{language.Key} - {language.Value}";
            Console.WriteLine(result);
        }
    }
}