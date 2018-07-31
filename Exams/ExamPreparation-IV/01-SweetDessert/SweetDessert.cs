using System;

class SweetDessert
{
    static void Main(string[] args)
    {
        decimal money = decimal.Parse(Console.ReadLine());
        int guestsCount = int.Parse(Console.ReadLine());
        decimal bananaPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        int cakes = Convert.ToInt32(Math.Ceiling(guestsCount / 6.0));
        decimal moneyNeeded = cakes * (2 * bananaPrice + 4 * eggsPrice + 0.2M * berriesPrice);

        if (money >= moneyNeeded)
        {
            Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - money:F2}lv more.");
        }
    }
}