using System;

class BalancedBrackets
{
    static void Main(string[] args)
    {
        int lines = int.Parse(Console.ReadLine());

        bool opened = false;
        bool balanced = true;


        for (int line = 0; line < lines; line++)
        {
            string text = Console.ReadLine();

            if (!opened && text == "(")
            {
                opened = true;
            }
            else if (opened && text == "(")
            {
                balanced = false;
            }
            else if (!opened && text == ")")
            {
                balanced = false;
            }
            else if (opened && text == ")")
            {
                opened = false;
            }
        }
        if (balanced && !opened)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}
