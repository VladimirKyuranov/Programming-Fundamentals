using System;
using System.Linq;
using System.Text.RegularExpressions;

class MelrahShake
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = Console.ReadLine();
        Regex regex = new Regex(Regex.Escape(pattern));
        Regex regexReversed = new Regex(Regex.Escape(string.Join("", pattern.Reverse())));

        while (regex.Matches(text).Count > 1 && pattern.Length > 0 && text.Length > 0)
        {
            text = regex.Replace(text, "", 1);
            text = string.Join("", text.Reverse());
            text = regexReversed.Replace(text, "", 1);
            text = string.Join("", text.Reverse());
            pattern = pattern.Remove(pattern.Length / 2, 1);
            regex = new Regex(Regex.Escape(pattern));
            regexReversed = new Regex(Regex.Escape(string.Join("", pattern.Reverse())));

            Console.WriteLine("Shaked it.");
        }

        Console.WriteLine("No shake.");
        Console.WriteLine(text);
    }
}