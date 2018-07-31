using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class KeyReplacer
{
    static void Main(string[] args)
    {
        string key = Console.ReadLine();
        string text = Console.ReadLine();

        string keyPattern = @"^(?<start>[a-zA-Z]+)([<\|\\])(.*)([<|\\])(?<end>[a-zA-Z]+)$";
        Match keys = Regex.Match(key, keyPattern);
        string startKey = keys.Groups["start"].Value;
        string endKey = keys.Groups["end"].Value;
        string extractPattern = $@"{startKey}(.*?){endKey}";
        MatchCollection extracted = Regex.Matches(text, extractPattern);
        List<string> results = new List<string>();

        foreach (Match m in extracted)
        {
            results.Add(m.Groups[1].Value);
        }

        string result = string.Join("", results);

        if (result != "")
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Empty result");
        }
    }
}
