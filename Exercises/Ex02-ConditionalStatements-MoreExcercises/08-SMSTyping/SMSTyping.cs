using System;

class SMSTyping
{
    static void Main(string[] args)
    {
        int lettersCount = int.Parse(Console.ReadLine());

        string output = "";

        for (int i = 0; i < lettersCount; i++)
        {
            int number = int.Parse(Console.ReadLine());

            int digits = number.ToString().Length;
            int mainDigit = int.Parse(number.ToString()[0].ToString());
            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset++;
            }

            int index = offset + digits - 1;

            if (number == 0)
            {
                output += ' ';
            }
            else
            {
                output += Convert.ToChar(97 + index);
            }
        }

        Console.WriteLine(output);
    }
}
