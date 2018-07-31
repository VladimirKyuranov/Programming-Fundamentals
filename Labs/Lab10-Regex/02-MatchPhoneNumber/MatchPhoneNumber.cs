using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4,4}\b";

        var validPhones = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", validPhones));
    }
}