using System;
using System.Collections.Generic;
using System.Linq;

class Snowwhite
{
    static void Main(string[] args)
    {
        List<Dwarf> dwarves = new List<Dwarf>();
        var hats = new Dictionary<string, int>();

        string input;

        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] dwarfStats = input
                .Split(" <:>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string dwarfName = dwarfStats[0];
            string dwarfHatColor = dwarfStats[1];
            int dwarfPhysics = int.Parse(dwarfStats[2]);

            Dwarf dwarf = new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics);
            Dwarf sameDwarf = dwarves.FirstOrDefault(d => d.Name == dwarf.Name
                && d.HatColor == dwarf.HatColor);

            if (sameDwarf != null)
            {
                if (sameDwarf.Physics < dwarf.Physics)
                {
                    sameDwarf.Physics = dwarf.Physics;
                }
            }
            else
            {
                dwarves.Add(dwarf);

                if (hats.ContainsKey(dwarf.HatColor) == false)
                {
                    hats.Add(dwarf.HatColor, 1);
                }

                hats[dwarf.HatColor]++;
            }
        }

        foreach (Dwarf dwarf in dwarves.OrderByDescending(d => d.Physics).ThenByDescending(d => hats[d.HatColor]))
        {
            Console.WriteLine(dwarf);
        }
    }
}

class Dwarf
{
    public Dwarf(string name, string hatColor, int physics)
    {
        this.Name = name;
        this.HatColor = hatColor;
        this.Physics = physics;
    }

    public string Name { get; }
    public string HatColor { get; }
    public int Physics { get; set; }

    public override string ToString()
    {
        string result = $"({this.HatColor}) {this.Name} <-> {this.Physics}";
        return result;
    }
}