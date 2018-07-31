using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class NetherRealms
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine()
            .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        List<Demon> demonBook = new List<Demon>();

        foreach (string name in names)
        {
            string healthPattern = @"[^\d\+\-\/\*\.]";
            string damagePattern = @"[\-\+]*\d+(\.\d+)*";
            string multiplier = @"\*";
            string divider = @"\/";

            MatchCollection healthMatches = Regex.Matches(name, healthPattern);
            MatchCollection damageMatches = Regex.Matches(name, damagePattern);
            MatchCollection multiplierMatches = Regex.Matches(name, multiplier);
            MatchCollection dividerMatches = Regex.Matches(name, divider);

            int health = healthMatches
                .Cast<Match>()
                .Select(h => (int)(Char.Parse(h.Value)))
                .Sum();
            double damage = damageMatches
                .Cast<Match>()
                .Select(h => double.Parse(h.Value))
                .Sum();

            if (multiplierMatches.Count > 0)
            {
                damage *= Math.Pow(2, multiplierMatches.Count);
            }

            if (dividerMatches.Count > 0)
            {
                damage /= Math.Pow(2, dividerMatches.Count);
            }

            Demon demon = new Demon
            {
                Name = name,
                Damage = damage,
                Health = health
            };

            demonBook.Add(demon);
        }

        foreach (Demon demon in demonBook.OrderBy(d => d.Name))
        {
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
        }
    }
}

class Demon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}