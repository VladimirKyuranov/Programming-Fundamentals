using System;
using System.Text;
using System.Text.RegularExpressions;

class Mines
{
    static void Main(string[] args)
    {
        string minefield = Console.ReadLine();
        string minePattern = @"<(.{2})>";

        var checkForMines = Regex.Match(minefield, minePattern);

        while (checkForMines.Success)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(minefield);
            string mine = checkForMines.Value;
            int mineIndex = minefield.IndexOf(checkForMines.Value);
            char first = checkForMines.Groups[1].Value[0];
            char second = checkForMines.Groups[1].Value[1];
            int blastRadius = Math.Abs(first - second);
            int startIndex = mineIndex - blastRadius;
            int length = 2 * blastRadius + 4;

            if (startIndex < 0)
            {
                length += startIndex;
                startIndex = 0;
                
            }


            if (startIndex + length > minefield.Length)
            {
                length = minefield.Length - startIndex;
            }

            builder.Remove(startIndex, length);
            builder.Insert(startIndex, new string('_', length));
            minefield = builder.ToString();

            checkForMines = checkForMines.NextMatch();
        }

        Console.WriteLine(minefield);
    }
}