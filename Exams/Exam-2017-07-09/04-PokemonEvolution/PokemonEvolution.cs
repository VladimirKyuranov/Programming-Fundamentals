using System;
using System.Collections.Generic;
using System.Linq;

class PokemonEvolution
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var pokemons = new Dictionary<string, List<Evolution>>();

        while (input != "wubbalubbadubdub")
        {
            string[] tokens = input
                .Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (tokens.Length > 1)
            {
                string pokemon = tokens[0];
                string evolutionType = tokens[1];
                int evolutionIndex = int.Parse(tokens[2]);

                if (pokemons.ContainsKey(pokemon) == false)
                {
                    pokemons.Add(pokemon, new List<Evolution>());
                }

                Evolution evolution = new Evolution {EvolutionType = evolutionType, EvolutionIndex = evolutionIndex };
                pokemons[pokemon].Add(evolution);
            }
            else if (pokemons.ContainsKey(input))
            {
                Console.WriteLine($"# {input}");

                foreach (var evolution in pokemons[input])
                {
                    Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
                }
            }

            input = Console.ReadLine();
        }

        foreach (var pokemon in pokemons)
        {
            Console.WriteLine($"# {pokemon.Key}");

            foreach (var evolution in pokemon.Value.OrderByDescending(e => e.EvolutionIndex))
            {
                Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
            }
        }
    }
}

class Evolution
{
    public string EvolutionType { get; set; }
    public int EvolutionIndex { get; set; }
}