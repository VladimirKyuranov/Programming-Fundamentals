using System;

class ForeignLanguages
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine().ToLower();

        string language = "unknown";

        switch (country)
        {
            case "england":
            case "usa":
                language = "English";
                break;
            case "spain":
            case "argentina":
            case "mexico":
                language = "Spanish";
                break;
        }

        Console.WriteLine(language);
    }
}
