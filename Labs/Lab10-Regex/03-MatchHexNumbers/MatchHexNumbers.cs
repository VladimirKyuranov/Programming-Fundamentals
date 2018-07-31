using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchHexNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"\b(0x)?[\dA-F]{2}\b";

        string[] numbers = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
