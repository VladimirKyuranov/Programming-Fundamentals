using System;
using System.Text;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lasttName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        long personalId = long.Parse(Console.ReadLine());
        int employeeNumber = int.Parse(Console.ReadLine());

        StringBuilder builder = new StringBuilder();

        builder.AppendLine($"First name: {firstName}")
            .AppendLine($"Last name: {lasttName}")
            .AppendLine($"Age: {age}")
            .AppendLine($"Gender: {gender}")
            .AppendLine($"Personal ID: {personalId}")
            .AppendLine($"Unique Employee number: {employeeNumber}");

        string result = builder.ToString().TrimEnd();
        Console.WriteLine(result);
    }
}
