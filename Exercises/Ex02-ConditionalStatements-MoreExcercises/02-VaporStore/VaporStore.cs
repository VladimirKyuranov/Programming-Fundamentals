using System;

class VaporStore
{
    static void Main(string[] args)
    {
        double ballance = double.Parse(Console.ReadLine());
        string game = Console.ReadLine().ToLower();

        double money = ballance;
        double gamePrice = 0;
        string boughtGame = "Not Found";

        while (game != "game time")
        {
            gamePrice = 0;

            switch (game)
            {
                case "outfall 4":
                    gamePrice = 39.99;
                    boughtGame = "Bought OutFall 4";
                    break;
                case "cs: og":
                    gamePrice = 15.99;
                    boughtGame = "Bought CS: OG";
                    break;
                case "zplinter zell":
                    gamePrice = 19.99;
                    boughtGame = "Bought Zplinter Zell";
                    break;
                case "honored 2":
                    gamePrice = 59.99;
                    boughtGame = "Bought Honored 2";
                    break;
                case "roverwatch":
                    gamePrice = 29.99;
                    boughtGame = "Bought RoverWatch";
                    break;
                case "roverwatch origins edition":
                    gamePrice = 39.99;
                    boughtGame = "Bought RoverWatch Origins Edition";
                    break;
                default:
                    boughtGame = "Not Found";
                    break;
            }

            if (money > gamePrice)
            {
                money -= gamePrice;
                Console.WriteLine($"{boughtGame}");
            }
            else if (money == gamePrice)
            {
                money -= gamePrice;
                Console.WriteLine($"{boughtGame}");
                Console.WriteLine("Out of money!");
                return;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            game = Console.ReadLine().ToLower();

        }

        if (money != 0)
        {
            Console.WriteLine($"Total spent: ${ballance - money:F2}. Remaining: ${money:F2}");
        }
    }
}
