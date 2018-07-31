using System;

class PhotoGallery
{
    static void Main(string[] args)
    {
        int photoNumber = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        int sizeInt = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        double convertedSize = sizeInt;
        string sizeLetter = "B";
        string orientation = "square";

        if (sizeInt >= 1000000)
        {
            convertedSize /= (double)1000000;
            sizeLetter = "MB";
        }
        else if (sizeInt >= 1000)
        {
            convertedSize /= (double)1000;
            sizeLetter = "KB";
        }

        if (width > height)
        {
            orientation = "landscape";
        }
        else if (height > width)
        {
            orientation = "portrait";
        }

        string name = $"Name: DSC_{photoNumber:D4}.jpg";
        string date = $"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}";
        string size = $"Size: {convertedSize}{sizeLetter}";
        string resolution = $"Resolution: {width}x{height} ({orientation})";

        Console.WriteLine($"{name}\r\n{date}\r\n{size}\r\n{resolution}");
    }
}
