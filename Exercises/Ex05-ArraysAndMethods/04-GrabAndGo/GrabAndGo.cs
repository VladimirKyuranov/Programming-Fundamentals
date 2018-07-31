using System;
using System.Linq;

class GrabAndGo
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());

        int[] numbers = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int numberIndex = -1;
        long sum = 0;

        for (int index = numbers.Length - 1; index >= 0; index--)
        {
            if (numbers[index] == number)
            {
                numberIndex = index;
                break;
            }
        }

        if (numberIndex > -1)
        {
            for (int index = 0; index < numberIndex; index++)
            {
                sum += numbers[index];
            }

            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}
