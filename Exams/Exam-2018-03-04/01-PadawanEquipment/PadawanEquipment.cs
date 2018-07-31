using System;

class PadawanEquipment
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        int studentsCount = int.Parse(Console.ReadLine());
        double lightSaberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        int lightSabersCount = Convert.ToInt32(Math.Ceiling(studentsCount * 1.1));
        int robesCount = studentsCount;
        int beltsCount = studentsCount - studentsCount / 6;
        double totalPrice = lightSabersCount * lightSaberPrice + robesCount * robePrice + beltsCount * beltPrice;

        if (money >= totalPrice)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {totalPrice - money:F2}lv more.");
        }
    }
}