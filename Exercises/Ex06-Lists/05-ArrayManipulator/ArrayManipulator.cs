using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        List<int> numbers = new List<int>();

        foreach (string item in input)
        {
            numbers.Add(int.Parse(item));
        }

		string commandsInput;

        while ((commandsInput = Console.ReadLine()) != "print")
        {
            List<string> commands = commandsInput
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            switch (commands[0])
            {
                case "add":
                    numbers = Add(numbers, commands);
                    break;
                case "addMany":
                    numbers = AddMany(numbers, commands);
                    break;
                case "contains":
                    Contains(numbers, commands);
                    break;
                case "remove":
                    numbers = Remove(numbers, commands);
                    break;
                case "shift":
                    numbers = Shift(numbers, commands);
                    break;
                case "sumPairs":
                    numbers = SumPairs(numbers);
                    break;
            }
        }

		Print(numbers);
    }

    private static List<int> Add(List<int> numbers, List<string> commands)
    {
        int index = int.Parse(commands[1]);
        int element = int.Parse(commands[2]);

        numbers.Insert(index, element);
        return numbers;
    }

    private static List<int> AddMany(List<int> numbers, List<string> commands)
    {
        int index = int.Parse(commands[1]);
        
        numbers.InsertRange(index, commands.Skip(2).Select(int.Parse));
        return numbers;
    }

    private static void Contains(List<int> numbers, List<string> commands)
    {
        int element = int.Parse(commands[1]);
        Console.WriteLine(numbers.IndexOf(element));
    }

    private static List<int> Remove(List<int> numbers, List<string> commands)
    {
        int index = int.Parse(commands[1]);

        numbers.RemoveAt(index);
        return numbers;
    }

    static List<int> Shift(List<int> numbers, List<string> commands)
    {
        int position = int.Parse(commands[1]) % numbers.Count;
        List<int> left = numbers.Take(position).ToList();

        numbers.RemoveRange(0, position);
        numbers.AddRange(left);
        return numbers;
    }

    static List<int> SumPairs(List<int> numbers)
    {
        List<int> result = new List<int>();

        for (int index = 0; index < numbers.Count; index += 2)
        {
            if (index < numbers.Count - 1)
            {
                result.Add(numbers[index] + numbers[index + 1]);
            }
            else
            {
                result.Add(numbers[index]);
            }
        }

        return result;
    }

    private static void Print(List<int> numbers)
    {
        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }
}