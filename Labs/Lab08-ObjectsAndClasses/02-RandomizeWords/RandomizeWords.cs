using System;
using System.Linq;

class RandomizeWords
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine()
            .Split()
            .ToArray();

        for (int index = 0; index < words.Length; index++)
        {
            Random rnd = new Random();
            int next = rnd.Next(0, words.Length);
            string temp = words[index];
            words[index] = words[next];
            words[next] = temp;
        }

        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
}