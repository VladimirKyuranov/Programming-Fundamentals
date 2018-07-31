using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurences
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .ToLower()
            .Split()
            .ToArray();

        var words = new Dictionary<string, int>();
        List<string> output = new List<string>();

        foreach (string word in input)
        {
            if (words.ContainsKey(word) == false)
            {
                words.Add(word, 0);
            }

            words[word]++;
        }

        foreach (var word in words)
        {
            if (word.Value % 2 != 0)
            {
                output.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", output));
    }
}