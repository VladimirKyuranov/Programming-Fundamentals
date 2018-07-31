using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

        string[] numbers = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}