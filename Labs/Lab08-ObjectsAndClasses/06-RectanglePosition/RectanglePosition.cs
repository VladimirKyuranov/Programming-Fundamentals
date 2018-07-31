using System;
using System.Linq;

class RectanglePosition
{
    static void Main(string[] args)
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();
        bool isInside = IsInside(firstRectangle, secondRectangle);

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not Inside");
        }
    }

    static Rectangle ReadRectangle()
    {
        double[] input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        return new Rectangle { X1 = input[0], Y1 = input[1], Width = input[2], Heigth = input[3] };
    }

    static bool IsInside(Rectangle first, Rectangle second)
    {
        if (first.X1 >= second.X1 && first.X2 <= second.X2 &&
            first.Y1 <= second.Y1 && first.Y2 <= second.Y2)
        {
            return true;
        }

        return false;
    }
}

class Rectangle
{
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double Width { get; set; }
    public double Heigth { get; set; }

    public double X2 { get { return X1 + Width; } }
    public double Y2 { get { return Y1 + Heigth; } }
}