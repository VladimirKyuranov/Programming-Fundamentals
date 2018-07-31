using System;
using System.Text;

class MultiplyBigNumber
    {
    static void Main(string[] args)
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
		string result = Multiply(firstWord, secondWord);

		Console.WriteLine(result);
	}

    static string Multiply(string firstWord, string secondWord)
    {
        StringBuilder builder = new StringBuilder();

        int remainder = 0;

        for (int index = firstWord.Length - 1; index >= 0; index--)
        {
            int sum = (firstWord[index] - 48) * (secondWord[0] - 48) + remainder;
            builder.Insert(0, sum % 10);
            remainder = sum / 10;

            if (index == 0)
            {
                builder.Insert(0, remainder);
            }
        }

		string result = builder.ToString().TrimStart('0');

        if (result.Length != 0)
        {
            return result;
        }
        else
        {
            return "0";
        }
    }
}
