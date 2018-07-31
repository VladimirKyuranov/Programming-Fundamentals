using System;

class Elevator
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int courses = Convert.ToInt32(Math.Ceiling(1.0 * people / capacity));

        Console.WriteLine(courses);
    }
}
