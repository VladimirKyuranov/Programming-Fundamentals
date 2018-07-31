using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        string[] firstPoint = Console.ReadLine()
            .Split()
            .ToArray();
        string[] secondPoint = Console.ReadLine()
            .Split()
            .ToArray();

        Point a = new Point { x = int.Parse(firstPoint[0]), y = int.Parse(firstPoint[1]) };
        Point b = new Point { x = int.Parse(secondPoint[0]), y = int.Parse(secondPoint[1]) };
        double distance = GetDistance(a, b);

        Console.WriteLine($"{distance:F3}");
    }

    private static double GetDistance(Point a, Point b)
    {
        double sideA = Math.Abs(a.x - b.x);
        double sideB = Math.Abs(a.y - b.y);
        double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        return distance;
    }
}

class Point
{
    public double x { get; set; }
    public double y { get; set; }
}