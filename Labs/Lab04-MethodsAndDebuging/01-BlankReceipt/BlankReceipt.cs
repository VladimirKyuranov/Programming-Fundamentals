using System;

class BlankReceipt
{
    static void Main(string[] args)
    {
        PrintReceipt();
    }

    static void PrintReceipt()
    {
        string border = new string('-', 30);

        PrintReceiptHeader(border);
        PrintReceiptBody();
        PrintReceiptFooter(border);
    }

    static void PrintReceiptHeader(string border)
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine(border);
    }

    static void PrintReceiptBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    static void PrintReceiptFooter(string border)
    {
        Console.WriteLine(border);
        Console.WriteLine("\u00A9 SoftUni");
    }
}
