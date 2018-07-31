using System;

class X
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        int leftSpacesCount = 0;
        int middleSpacesCount = size - 2;
        string row = "";

        for (int i = 0; i < size / 2; i++)
        {
            row = $"{new string(' ', leftSpacesCount)}x{new string(' ', middleSpacesCount)}x";
            Console.WriteLine(row);
            leftSpacesCount++;
            middleSpacesCount -= 2;
        }

        row = $"{new string(' ', leftSpacesCount)}x";
        Console.WriteLine(row);
        leftSpacesCount--;
        middleSpacesCount += 2;

        for (int i = 0; i < size / 2; i++)
        {
            row = $"{new string(' ', leftSpacesCount)}x{new string(' ', middleSpacesCount)}x";
            Console.WriteLine(row);
            leftSpacesCount--;
            middleSpacesCount += 2;
        }
    }
}
