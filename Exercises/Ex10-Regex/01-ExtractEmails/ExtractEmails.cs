using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(^|(?<=\s))[a-z\d]+[.-]?[a-z\d]+@[a-z]+([.-][a-z]+)+";

        string result = string.Join(Environment.NewLine, Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray());

        Console.WriteLine(result);
    }
}