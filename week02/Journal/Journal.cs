using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Attributes
    public List<Entry> _entries = new List<Entry>();

    // Behaviors
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is currently empty.");
            return;
        }

        Console.WriteLine("\n=== JOURNAL ENTRIES ===");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("----------------------------------------------------------------");
    }

    public void SaveToFile(string file)
    {
        // Using a highly unique delimiter "~|~" so users can type commas safely
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._mood}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: That file could not be found.");
            return;
        }

        // Clear existing entries before loading new ones as per spec requirements
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            // Split the line back into parts using our unique delimiter
            string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

            if (parts.Length == 4)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];
                loadedEntry._mood = parts[3];

                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}