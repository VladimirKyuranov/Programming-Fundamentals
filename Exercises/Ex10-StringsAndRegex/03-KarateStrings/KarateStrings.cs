using System;
using System.Linq;

class KarateStrings
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] parts = input
            .Split('>')
            .ToArray();
        int strength = 0;

        for (int index = 1; index < parts.Length; index++)
        {
            strength += int.Parse(parts[index][0].ToString());

            if (strength <= parts[index].Length)
            {
                parts[index] = parts[index].Remove(0, strength);
                strength = 0;
            }
            else
            {
                parts[index] = "";
                strength = strength - parts[index].Length - 1;
            }
        }

        string output = string.Join(">", parts);

        Console.WriteLine(output);
    }
}