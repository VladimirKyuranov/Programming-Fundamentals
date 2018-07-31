using System;

class SumOfChars
{
    static void Main(string[] args)
    {
        byte symbolsCount = byte.Parse(Console.ReadLine());

        int sum = 0;

        for (byte i = 0; i < symbolsCount; i++)
        {
            char symbol = char.Parse(Console.ReadLine());

            sum += (int)symbol;
        }

        Console.WriteLine($"The sum equals: {sum}");
    }
}
