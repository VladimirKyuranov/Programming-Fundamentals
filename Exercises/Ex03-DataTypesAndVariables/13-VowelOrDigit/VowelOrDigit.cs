using System;

class VowelOrDigit
{
    static void Main(string[] args)
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        if (symbol == 'a' || symbol == 'e' || symbol == 'i' ||
            symbol == 'o' || symbol == 'u' || symbol == 'y')
        {
            Console.WriteLine("vowel");
        }
        else if(symbol >= '0' && symbol <= '9')
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
