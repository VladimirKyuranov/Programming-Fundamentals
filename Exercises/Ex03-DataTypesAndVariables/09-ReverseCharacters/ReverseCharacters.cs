using System;

class ReverseCharacters
{
    static void Main(string[] args)
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        char secondSymbol = char.Parse(Console.ReadLine());
        char thirdSymbol = char.Parse(Console.ReadLine());

        string result = $"{thirdSymbol}{secondSymbol}{firstSymbol}";
        Console.WriteLine(result);
    }
}
