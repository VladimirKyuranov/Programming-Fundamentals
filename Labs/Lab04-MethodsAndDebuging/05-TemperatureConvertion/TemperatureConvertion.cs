using System;

class TemperatureConvertion
{
    static void Main(string[] args)
    {
        double farenheit = double.Parse(Console.ReadLine());

        double celsius = FarenheitToCelsius(farenheit);

        Console.WriteLine($"{celsius:F2}");
    }

    static double FarenheitToCelsius(double farenheit)
    {
        double celsius = (farenheit - 32) * 5 / 9;
        return celsius;
    }
}
