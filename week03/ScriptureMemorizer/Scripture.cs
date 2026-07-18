using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split text by space and convert strings into Word instances
        string[] splitWords = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        // Exceeding Requirements: Filter to only get words that are NOT already hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        // If there are fewer visible words than requested, adjust the count
        int actualToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < actualToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove from local tracking pool to prevent duplicates
        }
    }

    // Exceeding Requirements: Help user out by unhiding a random word
    public void RevealRandomWord()
    {
        List<Word> hiddenWords = _words.Where(w => w.IsHidden()).ToList();
        if (hiddenWords.Count > 0)
        {
            Random random = new Random();
            hiddenWords[random.Next(hiddenWords.Count)].Show();
        }
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = _words.Select(w => w.GetDisplayText()).ToList();
        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayedWords)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}