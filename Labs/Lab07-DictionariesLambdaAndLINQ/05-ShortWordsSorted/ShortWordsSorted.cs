using System;
using System.Linq;

class ShortWordsSorted
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine()
            .ToLower()
            .Split(".,:;()[]\"'\\/!? ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string output = string.Join(", ", words.Distinct().OrderBy(word => word).Where(word => word.Length < 5));

        Console.WriteLine(output);
    }
}