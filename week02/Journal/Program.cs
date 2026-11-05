using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");
        Journal journal = new Journal();
        while (journal._choice != 5)
        {
            journal.DisplayMenu();
        }
    }
}