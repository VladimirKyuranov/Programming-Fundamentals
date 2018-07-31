using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSubsequence
{
    static void Main(string[] args)
    {
        List<int> sequence = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        List<int> lis = new List<int>();
        int[] len = new int[sequence.Count];
        int[] prev = new int[sequence.Count];
        int lastIndex = -1;
        int bestLen = 0;

        for (int index = 0; index < sequence.Count; index++)
        {
            len[index] = 1;
            prev[index] = -1;

            for (int num = 0; num < index; num++)
            {
                if (sequence[index] > sequence[num] && len[num] + 1 > len[index])
                {
                    len[index] = 1 + len[num];
                    prev[index] = num;
                }
            }

            if (len[index] > bestLen)
            {
                bestLen = len[index];
                lastIndex = index;
            }
        }

        while (lastIndex != -1)
        {
            lis.Add(sequence[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        lis.Reverse();

        Console.WriteLine(string.Join(" ", lis));
    }
}
