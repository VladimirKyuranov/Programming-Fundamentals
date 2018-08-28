using System;

class PostOffice
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine()
            .Split('|', StringSplitOptions.RemoveEmptyEntries);
        string capitalsPattern = @"(?<symbol>[$])(?<capitals>[A-Z]+)\k<symbol>";
        string firstLetterAndLengthPattern = @"(?<firstLetter>[65-90]):(?<length>\d{2})";
    }
}