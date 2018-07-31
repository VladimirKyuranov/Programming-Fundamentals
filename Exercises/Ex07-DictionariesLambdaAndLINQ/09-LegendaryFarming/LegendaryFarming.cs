using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main(string[] args)
    {
        var materials = new Dictionary<string, int>();
        materials.Add("shards", 0);
        materials.Add("fragments", 0);
        materials.Add("motes", 0);

        while (materials["shards"] < 250 && materials["fragments"] < 250 && materials["motes"] < 250)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            for (int pair = 0; pair < input.Length; pair += 2)
            {
                string material = input[pair + 1];
                int quantity = int.Parse(input[pair]);

                if (materials.ContainsKey(material) == false)
                {
                    materials.Add(material, 0);
                }

                materials[material] += quantity;

                if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                {
                    break;
                }
            }
        }

        if (materials["shards"] >= 250)
        {
            Console.WriteLine("Shadowmourne obtained!");
            materials["shards"] -= 250;
        }
        else if (materials["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            materials["fragments"] -= 250;
        }
        else if (materials["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            materials["motes"] -= 250;
        }

        foreach (var material in materials
			.OrderByDescending(x => x.Value)
			.ThenBy(x => x.Key)
			.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes"))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }

        foreach (var material in materials
			.OrderBy(x => x.Key)
			.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes"))
        {
            Console.WriteLine($"{material.Key}: {material.Value}");
        }
    }
}