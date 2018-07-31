using System;
using System.Text;

class CharachterStats
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int health = int.Parse(Console.ReadLine());
        int healthMax = int.Parse(Console.ReadLine());
        int energy = int.Parse(Console.ReadLine());
        int energyMax = int.Parse(Console.ReadLine());

        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Name: {name}")
            .AppendLine($"Health: |{new string('|', health)}{new string('.', healthMax - health)}|")
            .AppendLine($"Energy: |{new string('|', energy)}{new string('.', energyMax - energy)}|");

        string result = builder.ToString().TrimEnd();
        Console.WriteLine(result);
    }
}
