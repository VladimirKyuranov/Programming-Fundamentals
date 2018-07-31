using System;

class PokeMon
{
    static void Main(string[] args)
    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exaustionFactor = int.Parse(Console.ReadLine());

        int pokesCount = 0;
        int initialPower = pokePower;

        while (pokePower >= distance)
        {
            pokePower -= distance;

            if (pokePower == initialPower * 0.5 && pokePower >= exaustionFactor && exaustionFactor != 0)
            {
                pokePower /= exaustionFactor;
            }

            pokesCount++;
        }

        Console.WriteLine(pokePower);
        Console.WriteLine(pokesCount);
    }
}