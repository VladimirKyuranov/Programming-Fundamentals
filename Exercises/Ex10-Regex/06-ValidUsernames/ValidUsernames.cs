using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"^[a-zA-z]\w{2,24}$";
        string[] usernames = input
            .Split(" /\\()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        List<string> users = new List<string>();

        foreach (string user in usernames)
        {
            if (Regex.IsMatch(user, pattern))
            {
                users.Add(user);
            }
        }

        int maxSum = 0;
        string firstUsername = string.Empty;
        string secondUsername = string.Empty;

        for (int index = 0; index < users.Count - 1; index++)
        {
            int sum = users[index].Length + users[index + 1].Length;

            if (sum > maxSum)
            {
                maxSum = sum;
                firstUsername = users[index];
                secondUsername = users[index + 1];
            }
        }

        Console.WriteLine(firstUsername);
        Console.WriteLine(secondUsername);
    }
}