using System;
using System.Linq;

class UpgradedMatcher
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
        long[] quantities = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();
        double[] prices = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();
        string orderInput = Console.ReadLine();

        while (orderInput != "done")
        {
            string[] order = orderInput
                .Split(' ')
                .ToArray();
            string name = order[0];
            long orderedQuantity = long.Parse(order[1]);
            int index = Array.IndexOf(names, name);
            long availableQuantity = 0;
            double price = prices[index];

            try
            {
                availableQuantity = quantities[index];
            }
            catch (Exception){}

            if (orderedQuantity <= availableQuantity)
            {
                Console.WriteLine($"{name} x {orderedQuantity} costs {orderedQuantity * price:F2}");
                quantities[index] -= orderedQuantity;
            }
            else
            {
                Console.WriteLine($"We do not have enough {name}");
            }

            orderInput = Console.ReadLine();
        }
    }
}