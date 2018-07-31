using System;

class ChoseADrink2
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        double price = 1.20;

        switch (profession)
        {
            case "Athlete":
                price = 0.7;
                break;
            case "Businessman":
            case "Businesswoman":
                price = 1;
                break;
            case "SoftUni Student":
                price = 1.7;
                break;
        }

        string result = $"The {profession} has to pay {quantity * price:F2}.";
        Console.WriteLine(result);
    }
}
