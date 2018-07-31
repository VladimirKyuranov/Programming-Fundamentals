using System;
using System.Collections.Generic;
using System.Linq;

class Snowmen
{
    static void Main(string[] args)
    {
        int[] sequence = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        List<Snowman> snowmen = new List<Snowman>();

        for (int index = 0; index < sequence.Length; index++)
        {
            Snowman snowman = new Snowman
            {
                Attack = sequence[index],
                Dead = false
            };

            snowmen.Add(snowman);
        }

        while (snowmen.Count > 1)
        {
            for (int index = 0; index < snowmen.Count; index++)
            {
                if (snowmen[index].Dead == false)
                {
                    int attacker = index;
                    int defender = snowmen[index].Attack % snowmen.Count;
                    int killed = Math.Abs(defender - attacker);

                    if (killed == 0)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        snowmen[attacker].Dead = true;
                    }
                    else if (killed % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {defender} -> {attacker} wins");
                        snowmen[defender].Dead = true;
                    }
                    else
                    {
                        Console.WriteLine($"{attacker} x {defender} -> {defender} wins");
                        snowmen[attacker].Dead = true;
                    }

                    if (MoreThanOne(snowmen) == false)
                    {
                        break;
                    }
                }
            }

            for (int index = snowmen.Count - 1; index >= 0; index--)
            {
                if (snowmen[index].Dead == true)
                {
                    snowmen.RemoveAt(index);
                }
            }
        }
    }

    static bool MoreThanOne(List<Snowman> snowmen)
    {
        int count = 0;

        foreach (Snowman snowman in snowmen)
        {
            if (snowman.Dead == false)
            {
                count++;
            }
        }

        if (count > 1)
        {
            return true;
        }

        return false;
    }
}

class Snowman
{
    public int Attack { get; set; }
    public bool Dead { get; set; }
}