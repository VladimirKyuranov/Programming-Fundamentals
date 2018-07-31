using System;

class WeatherForecast
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string output = "";

        try
        {
            long number = long.Parse(input);
            output = "Windy";
        }
        catch (Exception) { }

        try
        {
            int number = int.Parse(input);
            output = "Cloudy";
        }
        catch (Exception) { }

        try
        {
            sbyte number = sbyte.Parse(input);
            output = "Sunny";
        }
        catch (Exception) { }

        if (input.Contains("."))
        {
            output = "Rainy";
        }

        Console.WriteLine(output);
    }
}