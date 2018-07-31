using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MobaChalanger
{
	static void Main(string[] args)
	{
		var players = new Dictionary<string, Dictionary<string, int>>();

		string input;

		while ((input = Console.ReadLine()) != "Season end")
		{
			string[] commandArgs = input.Split();

			switch (commandArgs[1])
			{
				case "->":
					string playerName = commandArgs[0];
					string position = commandArgs[2];
					int skill = int.Parse(commandArgs[4]);
					AddPlayer(playerName, position, skill, players);
					break;
				case "vs":
					string playerOne = commandArgs[0];
					string playerTwo = commandArgs[2];
					Duel(playerOne, playerTwo, players);
					break;
			}
		}

		string result = PrintPlayers(players);

		Console.WriteLine(result);
	}

	private static void AddPlayer(string playerName, string position, int skill, Dictionary<string, Dictionary<string, int>> players)
	{
		if (players.ContainsKey(playerName) == false)
		{
			players.Add(playerName, new Dictionary<string, int>());
		}

		if (players[playerName].ContainsKey(position) == false)
		{
			players[playerName].Add(position, skill);
		}

		if (players[playerName][position] < skill)
		{
			players[playerName][position] = skill;
		}
	}

	private static void Duel(string playerOne, string playerTwo, Dictionary<string, Dictionary<string, int>> players)
	{
		if (players.ContainsKey(playerOne) == false || players.ContainsKey(playerTwo) == false)
		{
			return;
		}

		bool samePositionPresent = false;

		foreach (var fisrtPosition in players[playerOne].Keys)
		{
			if (players[playerTwo].ContainsKey(fisrtPosition))
			{
				samePositionPresent = true;
				break;
			}
		}

		if (samePositionPresent == false)
		{
			return;
		}

		int playerOneTotalSkill = players[playerOne].Values.Sum();
		int playerTwoTotalSkill = players[playerTwo].Values.Sum();

		if (playerOneTotalSkill == playerTwoTotalSkill)
		{
			return;
		}

		if (playerOneTotalSkill > playerTwoTotalSkill)
		{
			players.Remove(playerTwo);
		}
		else
		{
			players.Remove(playerOne);
		}
	}

	private static string PrintPlayers(Dictionary<string, Dictionary<string, int>> players)
	{
		StringBuilder builder = new StringBuilder();

		foreach (var player in players
			.OrderByDescending(p => p.Value.Values.Sum())
			.ThenBy(p => p.Key))
		{
			string playerName = player.Key;
			int totalSkill = player.Value.Values.Sum();
			builder.AppendLine($"{playerName}: {totalSkill} skill");

			foreach (var position in player.Value
				.OrderByDescending(p => p.Value)
				.ThenBy(p => p.Key))
			{
				string positionType = position.Key;
				int skill = position.Value;
				builder.AppendLine($"- {positionType} <::> {skill}");
			}
		}

		string result = builder.ToString().TrimEnd();

		return result;
	}
}