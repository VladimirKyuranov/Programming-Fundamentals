using System;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractSentencesByKeyword
{
    static void Main(string[] args)
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = text
            .Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        string pattern = $@"(^|(?<=\W)){keyword}($|(?=\W))";

        foreach (string sentence in sentences)
        {
            if (Regex.IsMatch(sentence, pattern))
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}