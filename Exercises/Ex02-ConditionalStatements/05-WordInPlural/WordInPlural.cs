using System;

class WordInPlural
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        if (word.EndsWith("y"))
        {
            word = word.Remove(word.Length - 1);
            word += "ies";
        }
        else if (word.EndsWith("o") || word.EndsWith("s")
            || word.EndsWith("x") || word.EndsWith("z")
            || word.EndsWith("ch") || word.EndsWith("sh"))
        {
            word += "es";
        }
        else
        {
            word += "s";
        }

        Console.WriteLine(word);
    }
}
