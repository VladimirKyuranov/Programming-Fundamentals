using System;

class MakeAWord
{
    static void Main(string[] args)
    {
        byte letters = byte.Parse(Console.ReadLine());

        string word = "";

        for (byte i = 0; i < letters; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            word += letter;
        }

        Console.WriteLine($"The word is: {word}");
    }
}
