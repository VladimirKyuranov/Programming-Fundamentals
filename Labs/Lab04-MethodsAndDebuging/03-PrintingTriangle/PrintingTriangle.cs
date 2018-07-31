using System;

class PrintingTriangle
{
    static void Main(string[] args)
    {
        PrintTriangle();
    }

    static void PrintTriangle()
    {
        int columns = int.Parse(Console.ReadLine());

        PrintTop(columns);
        PrintBottom(columns);
    }

    static void PrintTop(int columns)
    {
        for (int row = 1; row <= columns; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }
    }

    static void PrintBottom(int columns)
    {
        for (int row = columns - 1; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }

            Console.WriteLine();
        }
    }
}
