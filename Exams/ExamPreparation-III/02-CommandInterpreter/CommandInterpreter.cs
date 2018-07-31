using System;
using System.Collections.Generic;
using System.Linq;

class CommandInterpreter
{
    static void Main(string[] args)
    {
        List<string> strings = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "end")
        {
            string[] commands = input
                .Split()
                .ToArray();

            switch (commands[0])
            {
                case "reverse":
                    int index = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);

                    if (index < 0 || index >= strings.Count || index + count - 1 >= strings.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    strings = Reverse(strings, index, count);
                    break;
                case "sort":
                    index = int.Parse(commands[2]);
                    count = int.Parse(commands[4]);

                    if (index < 0 || index >= strings.Count ||index + count - 1 >= strings.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    strings = Sort(strings, index, count);
                    break;
                case "rollLeft":
                    count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    strings = RollLeft(strings, count);
                    break;
                case "rollRight":
                    int count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        break;
                    }

                    strings = RollRight(strings, count);
                    break;
            }
        }

        string output = string.Join(", ", strings);

        Console.WriteLine($"[{output}]");
    }

    private static List<string> RollRight(List<string> strings, int count)
    {
        for (int roll = 0; roll < count % strings.Count; roll++)
        {
            string lastElement = strings[strings.Count - 1];

            for (int index = strings.Count - 1; index > 0; index--)
            {
                strings[index] = strings[index - 1];
            }

            strings[0] = lastElement;
        }

        return strings;
    }

    private static List<string> RollLeft(List<string> strings, int count)
    {
        for (int roll = 0; roll < count % strings.Count; roll++)
        {
            string firstElement = strings[0];

            for (int index = 0; index < strings.Count - 1; index++)
            {
                strings[index] = strings[index + 1];
            }

            strings[strings.Count - 1] = firstElement;
        }

        return strings;
    }

    private static List<string> Sort(List<string> strings, int index, int count)
    {
        List<string> sorted = strings.Skip(index).Take(count).OrderBy(x => x).ToList();
        strings.RemoveRange(index, count);
        strings.InsertRange(index, sorted);

        return strings;
    }

    private static List<string> Reverse(List<string> strings, int index, int count)
    {
        List<string> reversed = strings.Skip(index).Take(count).Reverse().ToList();
        strings.RemoveRange(index, count);
        strings.InsertRange(index, reversed);

        return strings;
    }
}