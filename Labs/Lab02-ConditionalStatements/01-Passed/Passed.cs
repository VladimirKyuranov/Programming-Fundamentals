﻿using System;

class Passed
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        if (grade >= 3)
        {
            Console.WriteLine("Passed!");
        }
    }
}
