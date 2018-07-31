﻿using System;

class CenturiesToMinutes
{
    static void Main(string[] args)
    {
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        int days = Convert.ToInt32(years * 365.2422);
        int hours = days * 24;
        int minutes = hours * 60;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
    }
}
