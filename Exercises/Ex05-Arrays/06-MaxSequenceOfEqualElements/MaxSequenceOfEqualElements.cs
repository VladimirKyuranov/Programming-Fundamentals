using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] numbers = input
            .Split()
            .Select(int.Parse)
            .ToArray();
        string result = string.Empty;
        int sequenceLength = 0;


        for (int index = numbers.Length - 1; index > 0; index--)
        {
            int count = 0;
            string temp = $"{numbers[index]} ";

            for (int next = index - 1; next >= 0; next--)
            {
                if (numbers[index] == numbers[next])
                {
                    count++;
                    temp += $"{numbers[index]} ";
                }
                else
                {
                    break;
                }

            }

            if (count >= sequenceLength)
            {
                sequenceLength = count;
                result = temp;
            }
        }

        if (numbers.Length == 1 || sequenceLength == 0)
        {
            result = numbers[0].ToString();
        }

        Console.WriteLine(result.Trim());
    }
}