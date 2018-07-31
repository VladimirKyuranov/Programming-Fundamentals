using System;
using System.Linq;

class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int count = numbers.Length / 4;
        int[] upLeft = numbers.Take(count).Reverse().ToArray();
        int[] upRight = numbers.Reverse().Take(count).ToArray();
        int[] up = upLeft.Concat(upRight).ToArray();
        int[] down = numbers.Skip(count).Take(count * 2).ToArray();
        int[] result = up.Select((num, index) => num + down[index]).ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}