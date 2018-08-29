using System;
using System.Collections.Generic;
using System.Linq;

class IronGirder
{
    static void Main(string[] args)
    {
        Dictionary<string, Town> towns = new Dictionary<string, Town>();

        string input;

        while ((input = Console.ReadLine()) != "Slide rule")
        {
            string[] commandArgs = input
                .Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);

            string townName = commandArgs[0];
            int passengers = int.Parse(commandArgs[2]);

            if (commandArgs[1] == "ambush")
            {
                if (towns.ContainsKey(townName))
                {
                    towns[townName].Ambush(passengers);
                }
                continue;
            }

            int time = int.Parse(commandArgs[1]);

            if (towns.ContainsKey(townName) == false)
            {
                towns[townName] = new Town(townName, time, passengers);
            }
            else
            {
                if (towns[townName].Time > time || towns[townName].Time == 0)
                {
                    towns[townName].ChangeTime(time);
                }

                towns[townName].AddPassengers(passengers);
            }
        }

        towns
            .Select(t => t.Value)
            .Where(t => t.Time != 0 && t.Passengers != 0)
            .OrderBy(t => t.Time)
            .ThenBy(t => t.Name)
            .ToList()
            .ForEach(t => Console.WriteLine(t));
    }
}

class Town
{
    public Town(string name, int time, int passengers)
    {
        this.Name = name;
        this.Time = time;
        this.Passengers = passengers;
    }

    public string Name { get; private set; }
    public int Time { get; private set; }

    public int Passengers { get; private set; }


    public void AddPassengers(int passengers)
    {
        this.Passengers += passengers;
    }

    public void Ambush(int passengers)
    {
        this.Time = 0;
        this.Passengers -= passengers;
        if (this.Passengers < 0)
        {
            this.Passengers = 0;
        }
    }

    public void ChangeTime(int time)
    {
        this.Time = time;
    }

    public override string ToString()
    {
        string result = $"{this.Name} -> Time: {this.Time} -> Passengers: {this.Passengers}";
        return result;
    }
}