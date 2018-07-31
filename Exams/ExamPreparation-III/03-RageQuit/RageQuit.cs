using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class RageQuit
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"(?<text>\D+)(?<count>\d+)";
        MatchCollection strings = Regex.Matches(input, pattern);
        StringBuilder builder = new StringBuilder();
        List<char> unique = new List<char>();

        foreach (Match pair in strings)
        {
            string text = pair.Groups["text"].Value.ToUpper();
            int repeat = int.Parse(pair.Groups["count"].Value);

            for (int count = 0; count < repeat; count++)
            {
                builder.Append(text);
            }

            if (repeat != 0)
            {
                unique.AddRange(text);
            }
        }

        Console.WriteLine($"Unique symbols used: {unique.Distinct().Count()}");
        Console.WriteLine(builder);
    }
}
