using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string result = numbers[0].ToString();
		int sequenceLength = 0;

        for (int index = 0; index < numbers.Count - 1; index++)
        {
            int count = 0;
            List<int> temp = new List<int>();
            temp.Add(numbers[index]);

            for (int next = index + 1; next < numbers.Count; next++)
            {
                if (numbers[index] == numbers[next])
                {
                    count++;
                    temp.Add(numbers[index]);
                }
                else
                {
                    break;
                }
            }

            if (count > sequenceLength)
            {
                sequenceLength = count;
                result = string.Join(" ", temp);
            }
        }

        Console.WriteLine(result);
    }
}