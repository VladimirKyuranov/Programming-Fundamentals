using System;

class CakeIngredients
{
    static void Main(string[] args)
    {
        string ingredient;

        int count = 0;

        while ((ingredient = Console.ReadLine()) != "Bake!")
        {
            count++;
            Console.WriteLine($"Adding ingredient {ingredient}.");
        }

        Console.WriteLine($"Preparing cake with {count} ingredients.");
    }
}
