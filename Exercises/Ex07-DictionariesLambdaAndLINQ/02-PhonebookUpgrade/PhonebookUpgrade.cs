using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PhonebookUpgrade
{
    static void Main(string[] args)
    {
        var phonebook = new SortedDictionary<string, string>();

		string input;

		while ((input = Console.ReadLine()) != "END")
		{
			string[] commandArgs = input
				.Split()
				.ToArray();
			string command = commandArgs[0];
			
			switch (command)
            {
                case "A":
					string name = commandArgs[1];
					string phoneNumber = commandArgs[2];
					AddEntry(phonebook, name, phoneNumber);
                    break;
                case "S":
					name = commandArgs[1];
					string result = SearchEntry(phonebook, name);
					Console.WriteLine(result);
					break;
                case "ListAll":
                    result = ListAll(phonebook);
					Console.WriteLine(result);
                    break;
            }
        }
    }

    static string ListAll(SortedDictionary<string, string> phonebook)
    {
		StringBuilder builder = new StringBuilder();

        foreach (var contact in phonebook)
        {
            builder.AppendLine($"{contact.Key} -> {contact.Value}");
        }

		string result = builder.ToString().TrimEnd();
		return result;
    }

    static void AddEntry(SortedDictionary<string, string> phonebook, string name, string phoneNumber)
    {
        phonebook[name] = phoneNumber;
    }

	static string SearchEntry(SortedDictionary<string, string> phonebook, string name)
	{
		if (phonebook.ContainsKey(name) == false)
		{
			return $"Contact {name} does not exist.";
		}

		return $"{name} -> {phonebook[name]}";
	}
}
