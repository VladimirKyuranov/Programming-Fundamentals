using System;

class IndexOfLetters
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();

        char[] alphabet = new char[26];
        int letterIndex = 0;

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabet[letterIndex++] = letter;
        }

        for (int index = 0; index < word.Length; index++)
        {
            char currentLetter = word[index];
			string result = $"{currentLetter} -> {Array.IndexOf(alphabet, currentLetter)}";

			Console.WriteLine(result);
        }
    }
}