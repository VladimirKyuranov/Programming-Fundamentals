using System;
using System.Linq;

class CircleIntersection
{
    static void Main(string[] args)
    {
        Circle firstCircle = ReadCircle();
        Circle secondCircle = ReadCircle();

        Console.WriteLine(Intersection(firstCircle, secondCircle));
    }

    static Circle ReadCircle()
    {
        double[] input = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        Point center = new Point (input[0],input[1]);
        Circle circle = new Circle (center, input[2]);

        return circle;
    }

    static double GetDistance(Point a, Point b)
    {
        double sideA = Math.Abs(a.X - b.X);
        double sideB = Math.Abs(a.Y - b.Y);
        double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        return distance;
    }

    static string Intersection(Circle firstCircle, Circle secondCircle)
    {
        double distance = GetDistance(firstCircle.Center, secondCircle.Center);

        if (distance <= firstCircle.Radius + secondCircle.Radius)
        {
            return "Yes";
        }

        return "No";
    }
}

class Point
{
	public Point(double x, double y)
	{
		this.X = x;
		this.Y = y;
	}

    public double X { get; }
    public double Y { get; }
}

class Circle
{
	public Circle(Point center, double radius)
	{
		this.Center = center;
		this.Radius = radius;
	}

    public Point Center { get; }
    public double Radius { get; }
}