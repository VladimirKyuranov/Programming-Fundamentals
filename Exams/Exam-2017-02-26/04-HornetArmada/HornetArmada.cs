using System;
using System.Collections.Generic;
using System.Linq;

class HornetArmada
{
    static void Main(string[] args)
    {
        int inputsCount = int.Parse(Console.ReadLine());

        List<Legion> legions = new List<Legion>();
        string soldierType = string.Empty;

        for (int input = 0; input < inputsCount; input++)
        {
            string[] info = Console.ReadLine()
                .Split("=->: ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int lastActivity = int.Parse(info[0]);
            string legionName = info[1];
            soldierType = info[2];
            long soldiersCount = long.Parse(info[3]);
            var soldiers = new Dictionary<string, long>();
            soldiers.Add(soldierType, soldiersCount);

            if (legions.All(l => l.Name != legionName))
            {
                legions.Add(new Legion
                {
                    LastActivity = lastActivity,
                    Name = legionName,
                    Soldiers = soldiers
                });
            }
            else
            {
                Legion legion = legions.FirstOrDefault(l => l.Name == legionName);

                if (legion.LastActivity < lastActivity)
                {
                    legion.LastActivity = lastActivity;
                }

                if (legion.Soldiers.ContainsKey(soldierType) == false)
                {
                    legion.Soldiers.Add(soldierType, 0);
                }

                legion.Soldiers[soldierType] += soldiersCount;
            }
        }

        string[] command = Console.ReadLine()
            .Split("\\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        int activity = 0;
        soldierType = string.Empty;

        if (command.Length == 2)
        {
            activity = int.Parse(command[0]);
            soldierType = command[1];

            List<Legion> tempLegions = legions.Where(l => l.LastActivity < activity && l.Soldiers.ContainsKey(soldierType)).ToList();

            if (tempLegions.Count > 0)
            {
                foreach (Legion legion in tempLegions.OrderByDescending(l => l.Soldiers[soldierType]))
                {
                    Console.WriteLine($"{legion.Name} -> {legion.Soldiers[soldierType]}");
                }
            }
        }
        else
        {
            soldierType = command[0];

            foreach (Legion legion in legions.Where(l => l.Soldiers.ContainsKey(soldierType)).OrderByDescending(l => l.LastActivity))
            {
                Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
            }
        }
    }
}

class Legion
{
    public int LastActivity { get; set; }
    public string Name { get; set; }
    public Dictionary<string, long> Soldiers { get; set; }
}