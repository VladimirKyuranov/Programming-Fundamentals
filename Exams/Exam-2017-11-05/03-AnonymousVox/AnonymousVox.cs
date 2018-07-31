using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class AnonymousVox
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] replacements = Console.ReadLine()
            .Split("}{".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        string pattern = @"(?<start>[a-zA-Z]+)(?<core>.+)\k<start>";

        List<string> placeholders = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(x => x.Groups["core"].Value)
            .ToList();

        int minMembers = Math.Min(replacements.Length, placeholders.Count);

        for (int index = 0; index < minMembers; index++)
        {
            input = ReplaceFirst(input, placeholders[index], replacements[index]);
        }

        Console.WriteLine(input);
    }

    private static string ReplaceFirst(string input, string placeholder, string replacement)
    {
        int index = input.IndexOf(placeholder);
        StringBuilder builder = new StringBuilder();

        builder.Append(input.Substring(0, index));
        builder.Append(replacement);
        builder.Append(input.Substring(index + placeholder.Length));
        input = builder.ToString();
        return input;
    }
}