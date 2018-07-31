using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] numbers = input
            .Split()
            .Select(int.Parse)
            .ToArray();
        int number = -1;
        int maxCount = 0;

        for (int index = 0; index < numbers.Length - 1; index++)
        {
            int count = 0;
            int tempNumber = -1;

            for (int next = index; next < numbers.Length; next++)
            {
                if (numbers[index] == numbers[next])
                {
                    count++;
                    tempNumber = numbers[index];
                }
            }

            if (count > maxCount)
            {
                number = tempNumber;
                maxCount = count;
            }
        }

        if (numbers.Length == 1)
        {
            number = numbers[0];
        }

        Console.WriteLine(number);
    }
}