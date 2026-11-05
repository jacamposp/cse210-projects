using System;

public class Entry
{
    public DateTime _date;
    public string _prompt;
    public string _entry;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
        Console.WriteLine();
    }

    public void AddNewEntry(DateTime date, string promt, string entry)
    {
        _date = date;
        _prompt = promt;
        _entry = entry;
    }
}