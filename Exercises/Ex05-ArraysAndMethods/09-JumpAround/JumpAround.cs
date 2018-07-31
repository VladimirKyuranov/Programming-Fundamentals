using System;
using System.Linq;

class JumpAround
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int sum = numbers[0];
        int index = 0;

        while (true)
        {
            if (index + numbers[index] < numbers.Length)
            {
                index += numbers[index];
                sum += numbers[index];
            }
            else if (index - numbers[index] >= 0)
            {
                index -= numbers[index];
                sum += numbers[index];
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}
