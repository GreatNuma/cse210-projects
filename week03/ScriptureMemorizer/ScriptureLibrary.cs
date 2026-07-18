using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureLibrary
{
    private const string FileName = "scriptures.txt";
    private List<Scripture> _library = new List<Scripture>();

    public ScriptureLibrary()
    {
        LoadLibrary();
    }

    private void LoadLibrary()
    {
        // Automatically create a default file if it doesn't exist yet
        if (!File.Exists(FileName))
        {
            File.WriteAllLines(FileName, new[]
            {
                "John|3|16||For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
                "Proverbs|3|5|6|Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
                "Philippians|4|13||I can do all things through Christ which strengtheneth me."
            });
        }

        // Parse file data cleanly using pipe '|' separation
        string[] lines = File.ReadAllLines(FileName);
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');
            if (parts.Length < 5) continue;

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int startVerse = int.Parse(parts[2]);
            string endVerseRaw = parts[3];
            string text = parts[4];

            Reference reference;
            if (string.IsNullOrEmpty(endVerseRaw))
            {
                reference = new Reference(book, chapter, startVerse);
            }
            else
            {
                int endVerse = int.Parse(endVerseRaw);
                reference = new Reference(book, chapter, startVerse, endVerse);
            }

            _library.Add(new Scripture(reference, text));
        }
    }

    public Scripture GetRandomScripture()
    {
        if (_library.Count == 0) return null;
        Random random = new Random();
        return _library[random.Next(_library.Count)];
    }
}