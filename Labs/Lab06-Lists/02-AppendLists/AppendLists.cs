using System;
using System.Collections.Generic;
using System.Linq;

class AppendLists
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine()
            .Split('|')
            .ToList();
        
        string output = "";

        for (int index = input.Count - 1; index >= 0; index--)
        {
            int[] numbers = input[index]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            output += string.Join(" ", numbers) + " ";
        }

        Console.WriteLine(output.Trim());
    }
}
