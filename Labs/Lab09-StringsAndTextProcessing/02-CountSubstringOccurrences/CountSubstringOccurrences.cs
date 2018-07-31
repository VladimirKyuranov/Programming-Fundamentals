using System;

class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int count = 0;
        int index = text.IndexOf(pattern);

        while (index != -1)
        {
            count++;
            index = text.IndexOf(pattern, index + 1);
        }

        Console.WriteLine(count);
    }
}