using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main(string[] args)
    {
        List<string> words = Console.ReadLine()
            .Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<string> upperCase = new List<string>();
        List<string> lowerCase = new List<string>();
        List<string> mixedCase = new List<string>();

        foreach (string word in words)
        {
            switch (GetWordCasetype(word))
            {
                case "upper":
                    upperCase.Add(word);
                    break;
                case "lower":
                    lowerCase.Add(word);
                    break;
                case "mixed":
                    mixedCase.Add(word);
                    break;
            }
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
    }

    static string GetWordCasetype(string word)
    {
        string result = "mixed";

        if (word.All(char.IsLower))
        {
            result = "lower";
        }
        else if (word.All(char.IsUpper))
        {
            result = "upper";
        }

        return result;
    }
}