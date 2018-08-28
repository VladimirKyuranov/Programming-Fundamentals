using System;

class Hogswatch
{
    static void Main(string[] args)
    {
        int homes = int.Parse(Console.ReadLine());
        int initialPresents = int.Parse(Console.ReadLine());
        int presents = initialPresents;
        int homeCommings = 0;
        int additionalPresents = 0;

        for (int home = 1; home <= homes; home++)
        {
            int children = int.Parse(Console.ReadLine());
            if (presents >= children)
            {
                presents -= children;
                continue;
            }

            int presentsShort = children - presents;
            homeCommings++;
            int presentsToTake = initialPresents / (home) * (homes - home) + presentsShort;
            additionalPresents += presentsToTake;
            presents += presentsToTake - children;
        }

        if (homeCommings == 0)
        {
            Console.WriteLine(presents);
        }
        else
        {
            Console.WriteLine(homeCommings);
            Console.WriteLine(additionalPresents);
        }
    }
}