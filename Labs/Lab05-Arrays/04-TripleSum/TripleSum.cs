using System;
using System.Linq;

class TripleSum
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        bool pairPresent = false;
        long[] arr = input
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        for (int firstNum = 0; firstNum < arr.Length - 1; firstNum++)
        {
            for (int secondNum = firstNum + 1; secondNum < arr.Length; secondNum++)
            {
                for (int sum = 0; sum < arr.Length; sum++)
                {
                    if (arr[firstNum] + arr[secondNum] == arr[sum])
                    {
                        Console.WriteLine($"{arr[firstNum]} + {arr[secondNum]} == {arr[sum]}");
                        pairPresent = true;
                        break;
                    }
                }
            }
        }

        if (pairPresent == false)
        {
            Console.WriteLine("No");
        }
    }
}
