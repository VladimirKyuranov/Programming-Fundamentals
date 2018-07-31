using System;

class TriangleOfNumbers
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int rows = 1; rows <= size; rows++)
        {
            for (int columns = 0; columns < rows; columns++)
            {
                Console.Write($"{rows} ");
            }

            Console.WriteLine();
        }
    }
}
