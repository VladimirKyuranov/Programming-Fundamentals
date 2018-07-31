using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class UseYourChainsBuddy
{
    static void Main(string[] args)
    {
        int bufSize = 8192;
        Stream inStream = Console.OpenStandardInput(bufSize);
        Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize));

        string input = Console.ReadLine();

        string pattern = @"<p>(.*?)<\/p>";
        string[] paragraphs = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(m => m.Groups[1].Value)
            .ToArray();

        for (int paragraph = 0; paragraph < paragraphs.Length; paragraph++)
        {
            paragraphs[paragraph] = Regex.Replace(paragraphs[paragraph], @"[^a-z\d]+", " ");

            StringBuilder builder = new StringBuilder();

            for (int symbol = 0; symbol < paragraphs[paragraph].Length; symbol++)
            {
                if (paragraphs[paragraph][symbol] >= 'a' && paragraphs[paragraph][symbol] <= 'm')
                {
                    builder.Append((char)(paragraphs[paragraph][symbol] + 13));
                }
                else if (paragraphs[paragraph][symbol] >= 'n' && paragraphs[paragraph][symbol] <= 'z')
                {
                    builder.Append((char)(paragraphs[paragraph][symbol] - 13));
                }
                else
                {
                    builder.Append(paragraphs[paragraph][symbol]);
                }
            }

            paragraphs[paragraph] = builder.ToString();
        }

        string result = string.Join("", paragraphs);

        result = Regex.Replace(result, @"\s+|\n+", " ");
        Console.WriteLine(result);
    }
}