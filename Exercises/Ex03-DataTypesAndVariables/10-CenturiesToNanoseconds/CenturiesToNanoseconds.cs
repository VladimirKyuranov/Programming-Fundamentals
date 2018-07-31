using System;

class CenturiesToNanoseconds
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;

        string result = $"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {seconds}000 milliseconds = {seconds}000000 microseconds = {seconds}000000000 nanoseconds";
        Console.WriteLine(result);
    }
}
