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
                    Add(sands, value);
                    break;
                case "Remove":
                    Remove(sands, value, index);
                    break;
                case "Replace":
                    int replacement = int.Parse(commandArgs[2]);
                    Replace(sands, value, replacement, index);
                    break;
                case "Increase":
                    Increase(sands, value);
                    break;
                case "Collapse":
                    Collapse(sands, value);
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

    private static void Add(List<int> sands, int value)
    {
        sands.Add(value);
    }

    private static void Remove(List<int> sands, int value, int index)
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
    }

    private static void Replace(List<int> sands, int value, int replacement, int index)
    {
        if (index != -1)
        {
            sands[index] = replacement;
        }
    }

    private static void Increase(List<int> sands, int value)
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
    }

    private static void Collapse(List<int> sands, int value)
    {
        sands.RemoveAll(e => e < value);
    }
}