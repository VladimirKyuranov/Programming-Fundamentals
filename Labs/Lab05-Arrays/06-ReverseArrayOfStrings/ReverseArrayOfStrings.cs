using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] arrayToReverse = input
            .Split(' ')
            .ToArray();

        string[] reversedArray = arrayToReverse.Reverse().ToArray();

        Console.WriteLine(string.Join(" ", reversedArray));
    }
}