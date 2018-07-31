using System;

class TheatrePromotions
{
    static void Main(string[] args)
    {
        string typeOfDay = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());

        string output = "Error!";

        switch (typeOfDay)
        {
            case "weekday":
                if (age >= 0 && age <= 18)
                {
                    output = "12$";
                }
                else if (age <= 64 && age > 0)
                {
                    output = "18$";
                }
                else if (age <= 122 && age > 0)
                {
                    output = "12$";
                }
                break;
            case "weekend":
                if (age >= 0 && age <= 18)
                {
                    output = "15$";
                }
                else if (age <= 64 && age > 0)
                {
                    output = "20$";
                }
                else if (age <= 122 && age > 0)
                {
                    output = "15$";
                }
                break;
            case "holiday":
                if (age >= 0 && age <= 18)
                {
                    output = "5$";
                }
                else if (age <= 64 && age > 0)
                {
                    output = "12$";
                }
                else if (age <= 122 && age > 0)
                {
                    output = "10$";
                }
                break;
        }
        Console.WriteLine(output);
    }
}
