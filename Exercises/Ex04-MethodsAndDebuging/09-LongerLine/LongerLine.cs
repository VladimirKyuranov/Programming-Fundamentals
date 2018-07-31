using System;

class LongerLine
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        double firstLine = GetLineLenght(x1, y1, x2, y2);
        double secondLine = GetLineLenght(x3, y3, x4, y4);
        string output = "";

        if (firstLine >= secondLine)
        {
            output = GetClosestPoint(x1, y1, x2, y2);
        }
        else
        {
            output = GetClosestPoint(x3, y3, x4, y4);
        }

        Console.WriteLine(output);
    }

    static double GetLineLenght(double x1, double y1, double x2, double y2)
    {
        double lineLength = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

        return lineLength;
    }

    static string GetClosestPoint(double x1, double y1, double x2, double y2)
    {
        string result = "";
        double distanceFirstPoint = Math.Sqrt(x1 * x1 + y1 * y1);
        double distanceSecondPoint = Math.Sqrt(x2 * x2 + y2 * y2);

        if (distanceFirstPoint <= distanceSecondPoint)
        {
            result = $"({x1}, {y1})({x2}, {y2})";
        }
        else
        {
            result = $"({x2}, {y2})({x1}, {y1})";
        }

        return result;
    }
}
