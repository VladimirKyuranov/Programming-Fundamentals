using System;

class ChooseADrink
{
    static void Main(string[] args)
    {
        string profession = Console.ReadLine().ToLower();

        string drink = "Tea";

        switch (profession)
        {
            case "athlete":
                drink = "Water";
                break;
            case "businessman":
            case "businesswoman":
                drink = "Coffee";
                break;
            case "softuni student":
                drink = "Beer";
                break;
        }

        Console.WriteLine(drink);
    }
}
