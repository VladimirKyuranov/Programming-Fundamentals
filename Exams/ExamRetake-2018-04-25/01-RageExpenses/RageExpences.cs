using System;

class RageExpences
{
	static void Main(string[] args)
	{
		int lostGamesCount = int.Parse(Console.ReadLine());
		decimal headsetPrice = decimal.Parse(Console.ReadLine());
		decimal mousePrice = decimal.Parse(Console.ReadLine());
		decimal keyboardPrice = decimal.Parse(Console.ReadLine());
		decimal displayPrice = decimal.Parse(Console.ReadLine());
		int trashedHeadsets = lostGamesCount / 2;
		int trashedMouses = lostGamesCount / 3;
		int trashedKeyboards = lostGamesCount / 6;
		int trashedDisplays = trashedKeyboards / 2;
		decimal totalPrice =
			headsetPrice * trashedHeadsets +
			mousePrice * trashedMouses +
			keyboardPrice * trashedKeyboards +
			displayPrice * trashedDisplays;

		Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");
	}
}