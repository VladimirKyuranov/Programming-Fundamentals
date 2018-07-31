using System;
using System.Text;

class Hotel
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine().ToLower();
        int nights = int.Parse(Console.ReadLine());

        double studioPrice = 0;
        double doublePrice = 0;
        double suitePrice = 0;

        switch (month)
        {
            case "may":
            case "october":
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
                if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
                break;
            case "june":
            case "september":
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nights > 14)
                {
                    doublePrice *= 0.9;
                }
                break;
            case "july":
            case "august":
            case "december":
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nights > 14)
                {
                    suitePrice *= 0.85;
                }
                break;
        }

        double studioTotal = studioPrice * nights;

        if ((month == "september" || month == "october") && nights > 7)
        {
           studioTotal = studioPrice * (nights - 1);
        }

        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"Studio: {studioTotal:F2} lv.")
            .AppendLine($"Double: {doublePrice * nights:F2} lv.")
            .AppendLine($"Suite: {suitePrice * nights:F2} lv.");

        string result = builder.ToString().TrimEnd();
        Console.WriteLine(result);
    }
}
