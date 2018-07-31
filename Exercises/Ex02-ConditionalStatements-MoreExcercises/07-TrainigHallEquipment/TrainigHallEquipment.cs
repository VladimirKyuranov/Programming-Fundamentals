using System;

class TrainigHallEquipment
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int itemsCount = int.Parse(Console.ReadLine());

        double subTotal = 0;

        for (int i = 0; i < itemsCount; i++)
        {
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());

            if (itemCount > 1)
            {
                itemName += 's';
            }

            subTotal += itemPrice * itemCount;
            Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
        }

        Console.WriteLine($"Subtotal: ${subTotal:F2}");

        if (budget >= subTotal)
        {
            Console.WriteLine($"Money left: ${budget - subTotal:F2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${subTotal - budget:F2} more.");
        }
    }
}
