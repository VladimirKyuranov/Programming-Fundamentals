using System;
using System.Collections.Generic;
using System.Linq;

class DragonArmy
{
	static void Main(string[] args)
	{
		int dragonsCount = int.Parse(Console.ReadLine());
		DragonFactory dragonFactory = new DragonFactory();
		var dragons = new Dictionary<string, Dictionary<string, Dragon>>();

		for (int counter = 0; counter < dragonsCount; counter++)
		{
			string[] dragonArgs = Console.ReadLine()
				.Split()
				.ToArray();

			Dragon dragon = dragonFactory.CreateDragon(dragonArgs);

			if (dragons.ContainsKey(dragon.Type) == false)
			{
				dragons.Add(dragon.Type, new Dictionary<string, Dragon>());
			}

			dragons[dragon.Type][dragon.Name] = dragon;
		}

		foreach (var type in dragons)
		{
			double averageDamage = type.Value.Values.Average(x => x.Damage);
			double averageHealth = type.Value.Values.Average(x => x.Health);
			double averageArmor = type.Value.Values.Average(x => x.Armor);

			string typeResult = $"{type.Key}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})";
			Console.WriteLine(typeResult);

			foreach (var name in type.Value.OrderBy(x => x.Key))
			{
				string dragonResult = $"-{name.Key} -> damage: {name.Value.Damage}, health: {name.Value.Health}, armor: {name.Value.Armor}";
				Console.WriteLine(dragonResult);
			}
		}
	}
}

class Dragon
{
	public Dragon(string type, string name, int damage, int health, int armor)
	{
		this.Type = type;
		this.Name = name;
		this.Damage =  damage;
		this.Health = health;
		this.Armor = armor;
	}

	public string Type { get; }

	public string Name { get; }

	public int Damage { get; }

	public int Health { get; }

	public int Armor { get; }
}

class DragonFactory
{
	private const int defaultDamage = 45;
	private const int defaultHealth = 250;
	private const int defaultArmor = 10;

	public Dragon CreateDragon(string[] parameters)
	{
		string type = parameters[0];
		string name = parameters[1];
		int damage = parameters[2] == "null" ? defaultDamage : int.Parse(parameters[2]);
		int health = parameters[3] == "null" ? defaultHealth : int.Parse(parameters[3]);
		int armor = parameters[4] == "null" ? defaultArmor : int.Parse(parameters[4]);

		Dragon dragon = new Dragon(type, name, damage, health, armor);

		return dragon;
	}
}