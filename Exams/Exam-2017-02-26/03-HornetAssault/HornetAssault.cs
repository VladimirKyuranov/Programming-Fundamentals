using System;
using System.Collections.Generic;
using System.Linq;

class HornetAssault
{
    static void Main(string[] args)
    {
        List<long> beehives = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        List<long> hornets = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        for (int index = 0; index < beehives.Count; index++)
        {
            if (hornets.Count == 0)
            {
                break;
            }

            long hornetsPower = hornets.Sum();

            if (beehives[index] >= hornetsPower)
            {
                hornets.RemoveAt(0);
            }

            beehives[index] -= hornetsPower;
        }

        beehives.RemoveAll(x => x <= 0);

        if (beehives.Count > 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));

        }
    }
}