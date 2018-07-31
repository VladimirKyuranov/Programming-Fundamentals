using System;

class CubeProperties
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        string property = Console.ReadLine();

        double result = GetProperty(side, property);

        Console.WriteLine($"{result:F2}");
    }

    static double GetProperty(double side, string property)
    {
        double face = Math.Sqrt(Math.Pow(side, 2) * 2);
        double space = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(face, 2));
        double volume = Math.Pow(side, 3);
        double area = Math.Pow(side, 2) * 6;
        double result = 0;

        switch (property)
        {
            case "face":
                result = face;
                break;
            case "space":
                result = space;
                break;
            case "volume":
                result = volume;
                break;
            case "area":
                result = area;
                break;                                
        }

        return result;
    }
}
