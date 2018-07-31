using System;
using System.Collections.Generic;
using System.Linq;

class ChangeList
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        string commandInput = Console.ReadLine();

        while (true)
        {
            string[] commands = commandInput
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string command = commands[0];
            int element = 0;
            int position = 0;

            try
            {
                element = int.Parse(commands[1]);
                position = int.Parse(commands[2]);
            }
            catch (Exception) { }

            switch (command)
            {
                case "Delete":
                    numbers = Delete(numbers, element);
                    break;
                case "Insert":
                    numbers = Insert(numbers, element, position);
                    break;
                case "Odd":
                    Odd(numbers);
                    Environment.Exit(0);
                    break;
                case "Even":
                    Even(numbers);
                    Environment.Exit(0);
                    break;
            }

            commandInput = Console.ReadLine();
        }
    }

    private static List<int> Delete(List<int> numbers, int element)
    {
        numbers.RemoveAll(num => num == element);
        return numbers;
    }

    private static List<int> Insert(List<int> numbers, int element, int position)
    {
        numbers.Insert(position, element);
        return numbers;
    }

    private static void Odd(List<int> numbers)
    {
        string result = string.Join(" ", numbers.Where(num => num % 2 != 0));
        Console.WriteLine(result);
    }

    private static void Even(List<int> numbers)
    {
        string result = string.Join(" ", numbers.Where(num => num % 2 == 0));
        Console.WriteLine(result);
    }
}