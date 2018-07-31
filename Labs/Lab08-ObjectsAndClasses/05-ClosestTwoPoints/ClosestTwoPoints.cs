using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints
{
    static void Main(string[] args)
    {
        int pointsCount = int.Parse(Console.ReadLine());

        List<Point> points = new List<Point>();

        for (int currentPoint = 0; currentPoint < pointsCount; currentPoint++)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Point point = new Point { X = double.Parse(input[0]), Y = double.Parse(input[1]) };

            points.Add(point);
        }

        double minDistance = double.MaxValue;
        Point firstPoint = new Point();
        Point secondPoint = new Point();

        for (int first = 0; first < points.Count - 1; first++)
        {
            for (int second = first + 1; second < points.Count; second++)
            {
                double distance = GetDistance(points[first], points[second]);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    firstPoint = points[first];
                    secondPoint = points[second];
                }
            }
        }

        Console.WriteLine($"{minDistance:F3}");
        Console.WriteLine($"({firstPoint.X}, {firstPoint.Y})");
        Console.WriteLine($"({secondPoint.X}, {secondPoint.Y})");
    }

    private static double GetDistance(Point a, Point b)
    {
        double sideA = Math.Abs(a.X - b.X);
        double sideB = Math.Abs(a.Y - b.Y);
        double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        return distance;
    }
}

class Point
{
    public double X { get; set; }
    public double Y { get; set; }
}