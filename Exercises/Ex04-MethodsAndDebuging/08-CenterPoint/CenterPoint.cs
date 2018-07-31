using System;

class CenterPodouble
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        string closestPoint = GetClosestPoint(x1, y1, x2, y2);

        Console.WriteLine(closestPoint);
    }

    static string GetClosestPoint(double x1, double y1, double x2, double y2)
    {
        string result = "";

        double distanceFirstPoint = Math.Sqrt(x1 * x1 + y1 * y1);
        double distanceSecondPoint = Math.Sqrt(x2 * x2 + y2 * y2);

        if (distanceFirstPoint <= distanceSecondPoint)
        {
            result = $"({x1}, {y1})";
        }
        else
        {
            result = $"({x2}, {y2})";
        }

        return result;
    }
}
