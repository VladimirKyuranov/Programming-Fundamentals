using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var prices = new Dictionary<string, double>();
        var quantities = new Dictionary<string, int>();

        while (input != "stocked")
        {
            string[] products = input
                .Split()
                .ToArray();
            string name = products[0];
            double price = double.Parse(products[1]);
            int quantity = int.Parse(products[2]);

            if (quantities.ContainsKey(name) == false)
            {
                quantities.Add(name, 0);
            }

            prices[name] = price;
            quantities[name] += quantity;

            input = Console.ReadLine();
        }

        double grandTotal = 0;

        foreach (var product in prices)
        {
            double total = product.Value * quantities[product.Key];
            Console.WriteLine($"{product.Key}: ${product.Value:F2} * {quantities[product.Key]} = ${total:F2}");
            grandTotal += total;
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal:F2}");
    }
}