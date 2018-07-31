using System;

class MegaPixels
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        double pixels = width * height;
        double megaPixels = Math.Round(pixels / 1000000, 1);

        Console.WriteLine($"{width}x{height} => {megaPixels}MP");
    }
}
