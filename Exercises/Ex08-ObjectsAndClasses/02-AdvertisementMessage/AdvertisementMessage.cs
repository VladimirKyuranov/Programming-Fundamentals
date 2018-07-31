using System;

class AdvertisementMessage
{
	static void Main(string[] args)
	{
		int linesCount = int.Parse(Console.ReadLine());
		Random rnd = new Random();

		string[] phrases =
		{
			"Excellent product.",
			"Such a great product.",
			"I always use that product.",
			"Best product of its category.",
			"Exceptional product.",
			"I can’t live without this product."
		};

		string[] events =
		{
			"Now I feel good.",
			"I have succeeded with this product.",
			"Makes miracles. I am happy of the results!",
			"I cannot believe but now I feel awesome.",
			"Try it yourself, I am very satisfied.",
			"I feel great!"
		};

		string[] authors =
		{
			"Diana",
			"Petya",
			"Stella",
			"Elena",
			"Katya",
			"Iva",
			"Annie",
			"Eva"
		};

		string[] cities =
		{
			"Burgas",
			"Sofia",
			"Plovdiv",
			"Varna",
			"Ruse"
		};

		for (int line = 0; line < linesCount; line++)
		{
			string phrase = phrases[rnd.Next(0, phrases.Length)];
			string @event = events[rnd.Next(0, events.Length)];
			string author = authors[rnd.Next(0, authors.Length)];
			string city = cities[rnd.Next(0, cities.Length)];

			string result = $"{phrase} {@event} {author} - {city}";

			Console.WriteLine(result);
		}
	}
}