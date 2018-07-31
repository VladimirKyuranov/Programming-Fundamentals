using System;
using System.Text.RegularExpressions;

class OnlyLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(?<digits>\d+)(?<letter>[a-zA-Z])";
        var matches = Regex.Matches(input, pattern);

        foreach (Match pair in matches)
        {
            input = Regex.Replace(input, pair.Groups["digits"].Value, pair.Groups["letter"].Value);
        }

        Console.WriteLine(input);
    }
}