using System;
using System.Collections.Generic;
using System.Linq;

class GrainsOfSand
{
    static void Main(string[] args)
    {
        List<int> sands = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string input;

        while ((input = Console.ReadLine()) != "Mort")
        {
            string[] commandArgs = input.Split();
            string command = commandArgs[0];
            int value = int.Parse(commandArgs[1]);
            int index = sands.IndexOf(value);

            switch (command)
            {
                case "Add":
                    sands = Add(sands, value);
                    break;
                case "Remove":
                    sands = Remove(sands, value, index);
                    break;
                case "Replace":
                    int replacement = int.Parse(commandArgs[2]);
                    sands = Replace(sands, value, replacement, index);
                    break;
                case "Increase":
                    sands = Increase(sands, value);
                    break;
                case "Collapse":
                    sands = Collapse(sands, value);
                    break;
            }
        }

        Print(sands);
    }

    private static void Print(List<int> sands)
    {
        string result = string.Join(' ', sands);
        Console.WriteLine(result);
    }

    private static List<int> Add(List<int> sands, int value)
    {
        sands.Add(value);
        return sands;
    }

    private static List<int> Remove(List<int> sands, int value, int index)
    {
        if (index != -1)
        {
            sands.RemoveAt(index);
        }
        else
        {
            if (0 <= value && value < sands.Count)
            {
                sands.RemoveAt(value);
            }
        }

        return sands;
    }

    private static List<int> Replace(List<int> sands, int value, int replacement, int index)
    {
        if (index != -1)
        {
            sands[index] = replacement;
        }

        return sands;
    }

    private static List<int> Increase(List<int> sands, int value)
    {
        bool found = false;
        foreach (var sand in sands)
        {
            if (sand >= value)
            {
                value = sand;
                found = true;
                break;
            }
        }

        if (found == false)
        {
            value = sands.Last();
        }

        for (int elIndex = 0; elIndex < sands.Count; elIndex++)
        {
            sands[elIndex] += value;
        }

        return sands;
    }

    private static List<int> Collapse(List<int> sands, int value)
    {
        sands.RemoveAll(e => e < value);

        return sands;
    }
}