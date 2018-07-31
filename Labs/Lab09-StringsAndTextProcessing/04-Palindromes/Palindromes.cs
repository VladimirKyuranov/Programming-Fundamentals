using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Palindromes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .OrderBy(x => x)
            .ToArray();

        List<string> palindromes = new List<string>();

        foreach (var word in input)
        {
            if (word == ReverseText(word))
            {
                palindromes.Add(word);
            }
        }

        Console.WriteLine(string.Join(", ", palindromes));
    }

    static string ReverseText(string text)
    {
        StringBuilder builder = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            builder.Append(text[i]);
        }

        return builder.ToString();
    }
}