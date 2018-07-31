using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] commands = command
                .Split()
                .ToArray();

            switch (commands[0])
            {
                case "exchange":
                    int index = int.Parse(commands[1]);
                    Exchange(numbers, index);
                    break;
                case "max":
                    string type = commands[1];
                    Max(numbers, type);
                    break;
                case "min":
                    type = commands[1];
                    Min(numbers, type);
                    break;
                case "first":
                    int count = int.Parse(commands[1]);
                    type = commands[2];
                    First(numbers, count, type);
                    break;
                case "last":
                    count = int.Parse(commands[1]);
                    type = commands[2];
                    Last(numbers, count, type);
                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static void Exchange(List<int> numbers, int index)
    {
        if (0 > index || index >= numbers.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        int count = index + 1;
        List<int> firstPart = numbers.Take(count).ToList();

        numbers.RemoveRange(0, count);
        numbers.AddRange(firstPart);
    }

    private static void Max(List<int> numbers, string type)
    {
        int max = -1;
        List<int> temp = new List<int>();

        if (type == "even")
        {
            temp = numbers.Where(n => n % 2 == 0).ToList();
        }
        else
        {
            temp = numbers.Where(n => n % 2 != 0).ToList();
        }

        if (temp.Count > 0)
        {
            max = numbers.LastIndexOf(temp.Max());
        }

        if (max != -1)
        {
            Console.WriteLine(max);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    private static void Min(List<int> numbers, string type)
    {
        int min = -1;
        List<int> temp = new List<int>();

        if (type == "even")
        {
            temp = numbers.Where(n => n % 2 == 0).ToList();
        }
        else
        {
            temp = numbers.Where(n => n % 2 != 0).ToList();
        }

        if (temp.Count > 0)
        {
            min = numbers.LastIndexOf(temp.Min());
        }

        if (min != -1)
        {
            Console.WriteLine(min);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }

    private static void First(List<int> numbers, int count, string type)
    {
        if (count > numbers.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        List<int> result = new List<int>();

        if (type == "even")
        {
            result = numbers.Where(x => x % 2 == 0).Take(count).ToList();
        }
        else
        {
            result = numbers.Where(x => x % 2 != 0).Take(count).ToList();
        }

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }

    private static void Last(List<int> numbers, int count, string type)
    {
        if (count > numbers.Count)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        List<int> result = new List<int>();

        if (type == "even")
        {
            result = numbers.Where(x => x % 2 == 0).Reverse().Take(count).ToList();
            result.Reverse();

        }
        else
        {
            result = numbers.Where(x => x % 2 != 0).Reverse().Take(count).ToList();
            result.Reverse();
        }

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}