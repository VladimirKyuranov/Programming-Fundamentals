using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        int dayNumber = int.Parse(Console.ReadLine());

        string[] daysOfWeek = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        try
        {
            Console.WriteLine(daysOfWeek[dayNumber - 1]);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}