using System;
using System.Collections.Generic;
using System.Linq;

class ParkingValidation
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        var parking = new Dictionary<string, string>();

        for (int car = 0; car < count; car++)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string command = input[0];
            string user = input[1];

            if (command == "register")
            {
                string plate = input[2];
                char[] plateTemp = plate.ToCharArray();

                if (parking.ContainsKey(user) == false)
                {
                    if (plateTemp.Take(2).All(char.IsUpper) == false ||
                        plateTemp.Skip(6).All(char.IsUpper) == false ||
                        plateTemp.Skip(2).Take(4).All(char.IsDigit) == false)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (parking.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        parking.Add(user, plate);
                        Console.WriteLine($"{user} registered {parking[user]} successfully");
                    }
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                }
            }
            else
            {
                if (parking.ContainsKey(user) == false)
                {
                    Console.WriteLine($"ERROR: user {user} not found");
                }
                else
                {
                    parking.Remove(user);
                    Console.WriteLine($"user {user} unregistered successfully");
                }
            }
        }

        foreach (var car in parking)
        {
            Console.WriteLine($"{car.Key} => {car.Value}");
        }
    }
}