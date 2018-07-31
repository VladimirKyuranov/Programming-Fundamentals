using System;
using System.Linq;

class EnduranceRally
{
    static void Main(string[] args)
    {
        string[] drivers = Console.ReadLine()
            .Split()
            .ToArray();
        double[] zones = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        int[] checkpoints = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        foreach (string driver in drivers)
        {
            double fuel = driver[0];
            int zoneReached = 0;

            for (int zone = 0; zone < zones.Length; zone++)
            {
                if (fuel > zones[zone] || checkpoints.Contains(zone))
                {
                    if (checkpoints.Contains(zone))
                    {
                        fuel += zones[zone];
                    }
                    else
                    {
                        fuel -= zones[zone];
                    }

                    zoneReached = zone;
                }
                else
                {
                    zoneReached = zone;
                    break;
                }

                if (zoneReached == zones.Length - 1)
                {
                    zoneReached++;
                    break;
                }
            }

            if (zoneReached == zones.Length)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
            else
            {
                Console.WriteLine($"{driver} - reached {zoneReached}");
            }
        }
    }
}