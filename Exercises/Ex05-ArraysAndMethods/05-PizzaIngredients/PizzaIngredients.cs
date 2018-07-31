using System;
using System.Linq;

class PizzaIngredients
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int length = int.Parse(Console.ReadLine());

        string[] ingredients = input
            .Split(' ')
            .ToArray();
        int count = 0;
        string output = "";

        for (int ingredient = 0; ingredient < ingredients.Length; ingredient++)
        {
            if (ingredients[ingredient].Length == length && count < 10)
            {
                count++;
                Console.WriteLine($"Adding {ingredients[ingredient]}.");
                output += $"{ingredients[ingredient]}, ";
            }
        }

        output = $"Made pizza with total of {count} ingredients.\r\nThe ingredients are: {output.Remove(output.Length - 2)}.";
        Console.WriteLine(output);
    }
}