using System;
using System.Linq;
using System.Text;

class MorseCodeUpgraded
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split('|')
            .ToArray();

        StringBuilder output = new StringBuilder();

        foreach (string symbol in input)
        {
            int sum = 0;
            int len = 0;

            for (int digit = 0; digit < symbol.Length - 1; digit++)
            {
                if (symbol[digit] == symbol[digit + 1])
                {
                    len++;
                }
                else
                {
                    if (len > 0)
                    {
                        sum += len + 1;
                    }
                    len = 0;
                }

                if (digit == symbol.Length - 2 && len > 0)
                {
                    sum += len + 1;
                }
            }

            for (int digit = 0; digit < symbol.Length; digit++)
            {
                if (symbol[digit] == '0')
                {
                    sum += 3;
                }
                else
                {
                    sum += 5;
                }
            }

            output.Append((char)sum);
        }

        Console.WriteLine(output);
    }
}