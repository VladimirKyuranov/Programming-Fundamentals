using System;
using System.Globalization;

class SoftuniCoffeeOrders
{
    static void Main(string[] args)
    {
        int ordersCount = int.Parse(Console.ReadLine());
        decimal totalSum = 0;

        for (int currentOrder = 0; currentOrder < ordersCount; currentOrder++)
        {
            decimal capsulePrice = decimal.Parse(Console.ReadLine());
            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
            int capsulesCount = int.Parse(Console.ReadLine());

            int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
            decimal sum = capsulePrice * capsulesCount * days;

            totalSum += sum;
            Console.WriteLine($"The price for the coffee is: ${sum:F2}");
        }

        Console.WriteLine($"Total: ${totalSum:F2}");
    }
}