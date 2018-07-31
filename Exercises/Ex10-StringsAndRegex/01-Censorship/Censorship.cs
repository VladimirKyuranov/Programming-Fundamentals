using System;
using System.Text.RegularExpressions;

class Censorship
{
    static void Main(string[] args)
    {
        string bannedWord = Console.ReadLine();
        string text = Regex.Replace(Console.ReadLine(), bannedWord, new string('*', bannedWord.Length));

        Console.WriteLine(text);
    }
}
