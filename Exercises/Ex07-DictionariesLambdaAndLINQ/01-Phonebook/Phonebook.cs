using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
	static void Main(string[] args)
	{
		var phonebook = new Dictionary<string, string>();

		string input;

		while ((input = Console.ReadLine()) != "END")
		{
			string[] commandArgs = input
				.Split()
				.ToArray();
			string command = commandArgs[0];
			string name = commandArgs[1];


			switch (command)
			{
				case "A":
					string phoneNumber = commandArgs[2];
					AddEntry(phonebook, name, phoneNumber);
					break;
				case "S":
					string result = SearchEntry(phonebook, name);
					Console.WriteLine(result);
					break;
			}
		}
	}

	static void AddEntry(Dictionary<string, string> phonebook, string name, string phoneNumber)
	{
		phonebook[name] = phoneNumber;
	}

	static string SearchEntry(Dictionary<string, string> phonebook, string name)
	{
		if (phonebook.ContainsKey(name) == false)
		{
			return $"Contact {name} does not exist.";
		}

		return $"{name} -> {phonebook[name]}";
	}
}
