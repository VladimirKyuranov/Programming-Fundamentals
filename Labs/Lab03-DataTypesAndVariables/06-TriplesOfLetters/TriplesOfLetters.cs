using System;

class TriplesOfLetters
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (char symbolOne = 'a'; symbolOne < 'a' + number; symbolOne++)
        {
            for (char symbolTwo = 'a'; symbolTwo < 'a' + number; symbolTwo++)
            {
                for (char symbolThree = 'a'; symbolThree < 'a' + number; symbolThree++)
                {
                    Console.WriteLine($"{symbolOne}{symbolTwo}{symbolThree}");
                }
            }
        }
    }
}
