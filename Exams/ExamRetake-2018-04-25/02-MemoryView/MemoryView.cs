using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

class MemoryView
{
	static void Main(string[] args)
	{
		StringBuilder builder = new StringBuilder();
		string input;

		while ((input = Console.ReadLine()) != "Visual Studio crash")
		{
			builder.Append($"{input} ");
		}

		string text = builder.ToString().Trim();

		string lengthPattern = @"(?<start>32656 19759 32763 0 )(?<length>\d+) 0";

		MatchCollection lengthMatches = Regex.Matches(text, lengthPattern);

		List<int> lengths = new List<int>();

		foreach (Match match in lengthMatches)
		{
			int length = int.Parse(match.Groups["length"].Value);
			lengths.Add(length);
		}

		for (int index = 0; index < lengths.Count; index ++)
		{
			string pattern = $@"(?<start>32656 19759 32763 0 )(?<length>\d+) 0(?<text>( \d+){{{lengths[index]}}})";
			MatchCollection matches = Regex.Matches(text, pattern);
			string[] numbers = matches[index].Groups["text"].Value.Split().Skip(1).ToArray();
			int[] chars = numbers.Select(int.Parse).ToArray();
			
			builder.Clear();

			foreach (int symbol in chars)
			{
				builder.Append((char)symbol);
			}

			Console.WriteLine(builder);
		}
	}
}
