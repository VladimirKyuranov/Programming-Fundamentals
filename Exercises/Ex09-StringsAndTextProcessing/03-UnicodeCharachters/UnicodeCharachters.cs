using System;

class UnicodeCharachters
{
    static void Main(string[] args)
    {
        char[] text = Console.ReadLine()
            .ToCharArray();

        foreach (char symbol in text)
        {
            Console.Write($"\\u{(int)symbol:x4}");
        }
        Console.WriteLine();
    }
}