using System;
using System.Collections.Generic;
using System.Linq;

class SalesReport
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        var salesByTown = new SortedDictionary<string, double>();

        for (int currentSale = 0; currentSale < count; currentSale++)
        {
            Sale sale = ReadSale();
            if (salesByTown.ContainsKey(sale.Town) == false)
            {
                salesByTown.Add(sale.Town, 0);
            }

            salesByTown[sale.Town] += sale.totalPrice;
        }

        foreach (var town in salesByTown)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:F2}");
        }
    }

    static Sale ReadSale()
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();

        return new Sale { Town = input[0], Product = input[1], Price = double.Parse(input[2]), Quantity = double.Parse(input[3]) };
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }

    public double totalPrice { get { return Price * Quantity; } }
}