using System;

class GeometryCalculator
{
    static void Main(string[] args)
    {
        string figureType = Console.ReadLine();

        double area = 0;

        switch (figureType)
        {
            case "triangle":
                area = TriangleArea();
                break;
            case "square":
                area = SquareArea();
                break;
            case "rectangle":
                area = RectangleArea();
                break;
            case "circle":
                area = CircleArea();
                break;
        }

        Console.WriteLine($"{area:F2}");
    }

    static double TriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = side * height / 2;

        return area;
    }

    static double SquareArea()
    {
        double side = double.Parse(Console.ReadLine());

        double area = side * side;

        return area;
    }

    static double RectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;

        return area;
    }

    static double CircleArea()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);

        return area;
    }
}
