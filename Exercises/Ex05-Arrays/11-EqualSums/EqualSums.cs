using System;
using System.Linq;

class EqualSums
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int[] numbers = input
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        bool noPair = true;

        for (int index = 0; index < numbers.Length; index++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int left = 0; left < index; left++)
            {
                leftSum += numbers[left];
            }

            for (int right = index + 1; right < numbers.Length; right++)
            {
                rightSum += numbers[right];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(index);
                noPair = false;
            }
        }

        if (noPair)
        {
            Console.WriteLine("no");
        }
    }
}