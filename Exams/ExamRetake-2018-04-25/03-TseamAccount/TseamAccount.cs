using System;
using System.Collections.Generic;
using System.Linq;

class TseamAccount
{
	static void Main(string[] args)
	{
		List<string> account = Console.ReadLine()
			.Split()
			.ToList();

		string input;

		while ((input = Console.ReadLine()) != "Play!")
		{
			string[] commandArgs = input.Split();
			string command = commandArgs[0];
			string game = commandArgs[1];
			bool gamePresent = account.Contains(game);

			switch (command)
			{
				case "Install":
					Install(game, account, gamePresent);
					break;
				case "Uninstall":
					Uninstall(game, account, gamePresent);
					break;
				case "Update":
					Update(game, account, gamePresent);
					break;
				case "Expansion":
					string[] gameArgs = game.Split('-');
					game = gameArgs[0];
					string expansion = gameArgs[1];
					gamePresent = account.Contains(game);
					Expand(game, expansion, account, gamePresent);
					break;
			}
		}

		string result = PrintAccount(account);

		Console.WriteLine(result);
	}

	private static void Install(string game, List<string> account, bool gamePresent)
	{
		if (gamePresent == false)
		{
			account.Add(game);
		}
	}

	private static void Uninstall(string game, List<string> account, bool gamePresent)
	{
		if (gamePresent)
		{
			account.Remove(game);
		}
	}

	private static void Update(string game, List<string> account, bool gamePresent)
	{
		if (gamePresent)
		{
			account.Remove(game);
			account.Add(game);
		}
	}

	private static void Expand(string game, string expansion, List<string> account, bool gamePresent)
	{
		
		if (gamePresent)
		{
			int expansionIndex = account.IndexOf(game) + 1;
			expansion = $"{game}:{expansion}";
			account.Insert(expansionIndex, expansion);
		}
	}

	private static string PrintAccount(List<string> account)
	{
		string result = string.Join(" ", account);
		return result;
	}
}