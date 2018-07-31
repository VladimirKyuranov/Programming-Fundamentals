using System;

class TheaThePhotographer
{
    static void Main(string[] args)
    {
        long picturesTaken = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        long goodPictures = Convert.ToInt64(Math.Ceiling(1.0 * picturesTaken * filterFactor / 100));

        long totalFilterTime = picturesTaken * filterTime;
        long totalUploadTime = goodPictures * uploadTime;
        long seconds = totalFilterTime + totalUploadTime;

        long days = seconds / 86400;

        if (days > 0)
        {
            seconds %= days * 86400;
        }

        long hours = seconds / 3600;

        if (hours > 0)
        {
            seconds %= hours * 3600;
        }

        long minutes = seconds / 60;

        if (minutes > 0)
        {
            seconds %= minutes * 60;
        }

        Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");
    }
}
