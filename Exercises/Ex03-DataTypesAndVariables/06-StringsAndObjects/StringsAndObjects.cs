using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstText = Console.ReadLine();
        string secondText = Console.ReadLine();

        object output = firstText + " " + secondText;
        string result = output.ToString();

        Console.WriteLine(result);
    }
}
