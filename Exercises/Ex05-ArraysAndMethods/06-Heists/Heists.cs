using System;
using System.Linq;

class Heists
{
    static void Main(string[] args)
    {
        int[] prices = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        string heistDetails = Console.ReadLine();

        int jewelPrice = prices[0];
        int goldPrice = prices[1];
        int totalLoot = 0;
        int totalExpenses = 0;

        while (heistDetails != "Jail Time")
        {
            string[] lootExpenses = heistDetails
                .Split(' ')
                .ToArray();
            string loot = lootExpenses[0];

            totalExpenses += int.Parse(lootExpenses[1]);

            for (int index = 0; index < loot.Length; index++)
            {
                switch (loot[index])
                {
                    case '%':
                        totalLoot += jewelPrice;
                        break;
                    case '$':
                        totalLoot += goldPrice;
                        break;
                }
            }

            heistDetails = Console.ReadLine();
        }

        if (totalLoot >= totalExpenses)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {totalLoot - totalExpenses}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalLoot}.");
        }
    }
}