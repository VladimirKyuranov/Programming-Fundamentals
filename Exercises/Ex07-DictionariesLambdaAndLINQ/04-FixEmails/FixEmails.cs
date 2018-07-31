using System;
using System.Collections.Generic;
using System.Linq;

class FixEmails
{
    static void Main(string[] args)
    {
        string name = string.Empty;
        string email = string.Empty;
        var mailList = new Dictionary<string, string>();

        string input;

        while ((input = Console.ReadLine()) != "stop")
        {
            name = input;
            email = Console.ReadLine();

            if (mailList.ContainsKey(name) == false)
            {
                mailList.Add(name, email);
            }

            mailList[name] = email;
        }

        foreach (var entry in mailList.Where(entry => entry.Value.EndsWith(".us") == false && entry.Value.EndsWith(".uk") == false))
        {
            Console.WriteLine($"{entry.Key} -> {entry.Value}");
        }
    }
}