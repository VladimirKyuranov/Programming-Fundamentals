using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class PostOffice
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries);
        string capitalsPattern = @"(?<symbol>[$#%*&])(?<capitals>[A-Z]+)\k<symbol>";
        string firstLetterAndLengthPattern = @"(?<capital>6[5-9]|[78][0-9]|90):(?<length>\d{2})";

        string capitals = Regex.Match(input[0], capitalsPattern).Groups["capitals"].Value;
        MatchCollection capitalsAndLengthMatches = Regex.Matches(input[1], firstLetterAndLengthPattern);
        string[] words = input[2].Split();
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            foreach (Match match in capitalsAndLengthMatches)
            {
                char capital = (char)int.Parse(match.Groups["capital"].Value);
                int length = int.Parse(match.Groups["length"].Value);
                if (capitals.Contains(capital.ToString()))
                {
                    string wordPattern = $@"^{capital}[^ ]{{{length}}}$";
                    if (Regex.IsMatch(word, wordPattern))
                    {
                        result.Add(word);
                        break;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}