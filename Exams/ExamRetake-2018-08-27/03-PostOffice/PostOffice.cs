using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class PostOffice
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries);
        string capitalsPattern = @"(?<symbol>[$#%*&])(?<capitals>[A-Z]+)\k<symbol>";
        string lengthsPattern = @"(?<capital>6[5-9]|[78][0-9]|90):(?<length>\d{2})";

        char[] capitals = Regex.Match(input[0], capitalsPattern).Groups["capitals"].Value.ToCharArray();
        MatchCollection lengths = Regex.Matches(input[1], lengthsPattern);
        string[] words = input[2].Split();
        List<string> result = new List<string>();

        foreach (char capital in capitals)
        {
            int length = int.Parse(lengths
                .FirstOrDefault(l => (char)int.Parse(l.Groups["capital"].Value) == capital)
                .Groups["length"].Value);
            string wordPattern = $@"^{capital}\S{{{length}}}$";
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, wordPattern))
                {
                    result.Add(word);
                    break;
                }
            }
        }

        result = result.Distinct().ToList();
        Console.WriteLine(string.Join(Environment.NewLine, result));
    }
}