using System;

class BPMCounter
{
    static void Main(string[] args)
    {
        int bpm = int.Parse(Console.ReadLine());
        int beats = int.Parse(Console.ReadLine());

        double bars = 1.0 * beats / 4;
        int seconds = Convert.ToInt32(Math.Floor(1.0 * beats / bpm * 60));
        int minutes = 0;

        if (seconds >= 60)
        {
            minutes = seconds / 60;
            seconds = seconds % 60;
        }

        string output = $"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s";

        Console.WriteLine(output);
    }
}
