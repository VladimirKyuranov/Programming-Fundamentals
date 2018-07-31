﻿using System;

class RectangleProperties
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double lenght = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * lenght;
        double area = width * lenght;
        double diagonal = Math.Sqrt(width * width + lenght * lenght);

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}
