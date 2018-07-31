using System;
using System.Collections.Generic;
using System.Linq;

class PokemonDontGo
{
    static void Main(string[] args)
    {
        List<int> pokemons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int sum = 0;

        while (pokemons.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());

            int lastIndex = pokemons.Count - 1;
            int pokemon = 0;

            if (index < 0)
            {
                pokemon = pokemons[0];
                pokemons[0] = pokemons[lastIndex];
            }
            else if (index > lastIndex)
            {
                pokemon = pokemons[lastIndex];
                pokemons[lastIndex] = pokemons[0];
            }
            else
            {
                pokemon = pokemons[index];
                pokemons.RemoveAt(index);
            }

            sum += pokemon;

            for (int currentIndex = 0; currentIndex < pokemons.Count; currentIndex++)
            {
                if (pokemons[currentIndex] <= pokemon)
                {
                    pokemons[currentIndex] += pokemon;
                }
                else
                {
                    pokemons[currentIndex] -= pokemon;
                }
            }
        }

        Console.WriteLine(sum);
    }
}