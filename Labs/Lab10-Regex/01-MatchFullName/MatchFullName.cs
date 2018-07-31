using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchFullName
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        var names = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(" ", names));
    }
}