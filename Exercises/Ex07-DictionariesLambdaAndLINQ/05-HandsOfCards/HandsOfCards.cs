using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
	static void Main(string[] args)
	{
		var playersPowers = new Dictionary<string, int>();
		var playersCards = new Dictionary<string, List<string>>();

		string input;

		while ((input = Console.ReadLine()) != "JOKER")
		{
			string[] playerArgs = input
				.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			string name = playerArgs[0];
			List<string> cards = playerArgs[1]
				.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			if (playersCards.ContainsKey(name) == false)
			{
				playersCards.Add(name, new List<string>());
			}

			playersCards[name].AddRange(cards);
		}

		foreach (var player in playersCards)
		{
			int totalPower = 0;
			foreach (string cardSet in player.Value.Distinct())
			{
				char[] cards = cardSet.ToCharArray();
				int power = 0;

				switch (cards.First())
				{
					case '1':
						power += 10;
						break;
					case 'J':
						power += 11;
						break;
					case 'Q':
						power += 12;
						break;
					case 'K':
						power += 13;
						break;
					case 'A':
						power += 14;
						break;
					default:
						power += int.Parse(cards.First().ToString());
						break;
				}

				switch (cards.Last())
				{
					case 'D':
						power *= 2;
						break;
					case 'H':
						power *= 3;
						break;
					case 'S':
						power *= 4;
						break;
				}

				totalPower += power;
			}
			playersPowers.Add(player.Key, totalPower);
		}

		foreach (var player in playersPowers)
		{
			Console.WriteLine($"{player.Key}: {player.Value}");
		}
	}
}