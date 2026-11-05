using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


public class Journal
{
    public int _choice;
    public List<Entry> _entries = new List<Entry>();

    public void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
        Console.Write("What would you like to do? ");
        _choice = int.Parse(Console.ReadLine());
        OptionPick(_choice);
    }

    public void OptionPick(int option)
    {
        switch (option)
        {
            case 1:
                Write();
                break;

            case 2:
                Display();
                break;

            case 3:
                Load();
                break;

            case 4:
                Save();
                break;

            case 5:
                break;

        }
    }

    public void Write()
    {
        Prompt prompt = new Prompt();
        Entry entry = new Entry();
        entry.AddNewEntry(DateTime.Today, prompt.RandomPrompt(), Console.ReadLine());
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }


    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        if (Path.GetExtension(filename).Equals(".json"))
        {
            string json = File.ReadAllText(filename);
            _entries = JsonSerializer.Deserialize<List<Entry>>(json, new JsonSerializerOptions { IncludeFields = true });
        }
        else
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string text = parts[2];
                Entry entry = new Entry();
                entry.AddNewEntry(date, prompt, text);
                _entries.Add(entry);

            }
        }

    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        Console.WriteLine("Do you prefer to save the file as: ");
        Console.WriteLine("1. .txt");
        Console.WriteLine("2. .json");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 2)
        {
            string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { IncludeFields = true });
            File.WriteAllText($"{filename}.json", json);
        }
        else
        {

            using (StreamWriter outputFile = new StreamWriter($"{filename}.txt"))
            {
                // You can add text to the file with the WriteLine method
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}, {entry._prompt}, {entry._entry}");
                }
            }
        }

    }


}