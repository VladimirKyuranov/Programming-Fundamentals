using System;

class MagicLetter
{
    static void Main(string[] args)
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char bannedLetter = char.Parse(Console.ReadLine());

        for (char symbolOne = firstLetter; symbolOne <= secondLetter; symbolOne++)
        {
            for (char symbolTwo = firstLetter; symbolTwo <= secondLetter; symbolTwo++)
            {
                for (char symbolThree = firstLetter; symbolThree <= secondLetter; symbolThree++)
                {
                    if (symbolOne != bannedLetter && symbolTwo != bannedLetter && symbolThree != bannedLetter)
                    {
                        Console.Write($"{symbolOne}{symbolTwo}{symbolThree} ");
                    }
                }
            }
        }
    }
}
