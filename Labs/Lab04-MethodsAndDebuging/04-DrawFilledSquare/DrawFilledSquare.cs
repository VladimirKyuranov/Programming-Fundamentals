using System;

class DrawFilledSquare
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        PrintFilledSquare(size);
    }

    static void PrintFilledSquare(int size)
    {
        PrintTopBottomRow(size);
        PrintMiddleRows(size);
        PrintTopBottomRow(size);
    }

    static void PrintTopBottomRow(int size)
    {
        string row = new string('-', size * 2);

        Console.WriteLine(row);
    }

    static void PrintMiddleRows(int size)
    {
        for (int row = 0; row < size - 2; row++)
        {
            Console.Write("-");

            for (int col = 0; col < size - 1; col++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }
    }
}