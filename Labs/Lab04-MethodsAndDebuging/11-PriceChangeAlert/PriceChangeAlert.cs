using System;

class PriceChangeAlert
{
    static void Main(string[] args)
    {
        int pricesCount = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int price = 0; price < pricesCount - 1; price++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double difference = DifferenceInPercets(lastPrice, currentPrice);
            bool isSignificantDifference = IsSignificantDifference(difference, threshold);
            string message = OutputMessage(currentPrice, lastPrice, difference, isSignificantDifference);

            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string OutputMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)

    {
        string message = "";

        if (difference == 0)
        {
            message = $"NO CHANGE: {currentPrice}";
        }
        else if (!isSignificantDifference)
        {
            message = $"MINOR CHANGE: {lastPrice} to {currentPrice} ({difference:F2}%)";
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = $"PRICE UP: {lastPrice} to {currentPrice} ({difference:F2}%)";
        }
        else if (isSignificantDifference && (difference < 0))
            message = $"PRICE DOWN: {lastPrice} to {currentPrice} ({difference:F2}%)";

        return message;
    }
    private static bool IsSignificantDifference(double difference, double threshold)
    {
        if (Math.Abs(difference) >= threshold * 100)
        {
            return true;
        }

        return false;
    }

    private static double DifferenceInPercets(double lastPrice, double currentPrice)
    {
        double differenceInPercents = (currentPrice - lastPrice) / lastPrice * 100;
        return differenceInPercents;
    }
}
