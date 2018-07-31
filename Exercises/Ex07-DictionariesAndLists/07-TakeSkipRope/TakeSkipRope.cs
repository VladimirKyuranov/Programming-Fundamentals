using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope
{
    static void Main(string[] args)
    {
        char[] input = Console.ReadLine()
            .ToCharArray();

        List<int> numbers = new List<int>();
        List<char> chars = new List<char>();

        foreach (var symbol in input)
        {
            try
            {
                numbers.Add(int.Parse(symbol.ToString()));
            }
            catch (Exception)
            {
                chars.Add(symbol);
            }
        }

        List<int> take = new List<int>();
        List<int> skip = new List<int>();

        for (int index = 0; index < numbers.Count; index++)
        {
            if (index % 2 == 0)
            {
                take.Add(numbers[index]);
            }
            else
            {
                skip.Add(numbers[index]);
            }
        }

        List<char> result = new List<char>();
        int possition = 0;

        for (int index = 0; index < take.Count; index++)
        {
            result.AddRange(chars.Skip(possition).Take(take[index]));
            possition += take[index] + skip[index];
        }

        Console.WriteLine(string.Join("", result));
    }
}
