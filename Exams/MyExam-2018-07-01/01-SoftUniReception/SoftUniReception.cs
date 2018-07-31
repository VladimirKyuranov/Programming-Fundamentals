using System;


class SoftUniReception
{
    static void Main(string[] args)
    {
        int firstEmployeeSpeed = int.Parse(Console.ReadLine());
        int secondEmployeeSpeed = int.Parse(Console.ReadLine());
        int thirdEmployeeSpeed = int.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());

        int totalworkingSpeed = firstEmployeeSpeed + secondEmployeeSpeed + thirdEmployeeSpeed;
        int hours = 0;

        if (studentsCount == 0)
        {
            Console.WriteLine("Time needed: 0h.");
            Environment.Exit(0);
        }

        while (true)
        {
            if (hours % 4 == 0)
            {
                hours++;
                continue;
            }

            studentsCount -= totalworkingSpeed;

            if (studentsCount <= 0)
            {
                break;
            }

            hours++;
        }

        string result = $"Time needed: {hours}h.";
        Console.WriteLine(result);
    }
}