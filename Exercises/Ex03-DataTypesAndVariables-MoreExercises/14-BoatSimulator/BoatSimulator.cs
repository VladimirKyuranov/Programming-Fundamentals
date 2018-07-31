using System;

class BoatSimulator
{
    static void Main(string[] args)
    {
        char firstBoat = char.Parse(Console.ReadLine());
        char secondBoat = char.Parse(Console.ReadLine());
        int linesCount = int.Parse(Console.ReadLine());

        int firstBoatProgress = 0;
        int secondBoatProgress = 0;

        for (int turn = 1; turn <= linesCount; turn++)
        {
            string speed = Console.ReadLine();

            if (speed == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
            }
            else
            {
                if (turn % 2 != 0)
                {
                    firstBoatProgress += speed.Length;
                    if (firstBoatProgress >= 50)
                    {
                        Console.WriteLine(firstBoat);

                        return;
                    }
                }
                else
                {
                    secondBoatProgress += speed.Length;
                    if (secondBoatProgress >= 50)
                    {
                        Console.WriteLine(secondBoat);

                        return;
                    }
                }
            }
        }
        if (firstBoatProgress > secondBoatProgress)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoat);
        }
    }
}
