using System;
using System.Text.RegularExpressions;

class RegexMon
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        string didimon = @"[^a-zA-Z\-]+";
        string bojomon = @"[a-zA-Z]+\-[a-zA-Z]+";
        int turn = 0;

        Match nextMatch = Regex.Match(text, didimon);

        while (true)
        {
            if (turn % 2 == 0)
            {
                nextMatch = Regex.Match(text, didimon);

                turn++;
            }
            else
            {
                nextMatch = Regex.Match(text, bojomon);

                turn++;
            }

            if (nextMatch.Success == false)
            {
                break;
            }

            int matxhIndex = text.IndexOf(nextMatch.Value);
            int matchLength = nextMatch.Value.Length;
            int removeLength = matxhIndex + matchLength;

            text = text.Remove(0, removeLength);
            Console.WriteLine(nextMatch.Value);
        }
    }
}