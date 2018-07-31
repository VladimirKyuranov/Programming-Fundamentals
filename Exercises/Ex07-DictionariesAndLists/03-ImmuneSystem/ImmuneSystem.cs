using System;
using System.Collections.Generic;
using System.Linq;

class ImmuneSystem
{
    static void Main(string[] args)
    {
        int initialHealth = int.Parse(Console.ReadLine());
        string virus = Console.ReadLine();

        int currentHealth = initialHealth;
        var viruses = new List<string>();

        while (virus != "end")
        {
            int virusStrength = virus.ToCharArray().Sum(x => x) / 3;
            int seconds = virusStrength * virus.Length;

            if (viruses.Contains(virus) == false)
            {
                viruses.Add(virus);
            }
            else
            {
                seconds /= 3;
            }

            currentHealth -= seconds;

            string time = $"{seconds / 60}m {seconds % 60}s";

            Console.WriteLine($"Virus {virus}: {virusStrength} => {seconds} seconds");

            if (currentHealth > 0)
            {
                Console.WriteLine($"{virus} defeated in {time}.");
                Console.WriteLine($"Remaining health: {currentHealth}");
            }
            else
            {
                Console.WriteLine("Immune System Defeated.");
                break;
            }

            currentHealth = Convert.ToInt32(Math.Floor(currentHealth * 1.2));

            if (currentHealth > initialHealth)
            {
                currentHealth = initialHealth;
            }

            virus = Console.ReadLine();
        }

        if (currentHealth > 0)
        {
            Console.WriteLine($"Final Health: {currentHealth}");
        }
    }
}