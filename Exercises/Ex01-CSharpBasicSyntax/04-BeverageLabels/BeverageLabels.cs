using System;

class BeverageLabels
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyContentPer100ml = double.Parse(Console.ReadLine());
        double sugarContentPer100ml = double.Parse(Console.ReadLine());

        double energyContentTotal = energyContentPer100ml * volume / 100;
        double sugarContentTotal = sugarContentPer100ml * volume / 100;
        string result = $"{volume}ml {name}:{Environment.NewLine}{energyContentTotal}kcal, {sugarContentTotal}g sugars";

        Console.WriteLine(result);
    }
}
