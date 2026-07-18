using System;

/*
========================================================================================
 CREATIVITY & EXCEEDING REQUIREMENTS REPORT
========================================================================================
 1. Smart Filtering Pool: I modified Scripture.HideRandomWords() to filter out words 
    that are already hidden. This stops the generator from wasting turns on blank spaces.
 
 2. File-Driven Multi-Scripture Library: Built a ScriptureLibrary class that handles 
    external I/O via "scriptures.txt". It automatically generates placeholder content 
    with single and multi-verse data if no local file is present.
 
 3. Contextual Help System: I implemented a user fallback command. Typing 'hint' instead 
    of pressing Enter targets a hidden word at random and brings it back onto the 
    screen to nudge users forward when stuck.
========================================================================================
*/

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        if (scripture == null)
        {
            Console.WriteLine("Error: Unable to load or generate scripture dataset.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Break loop immediately if everything is successfully hidden 
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Excellent work! You have fully hidden the passage.");
                break;
            }

            Console.WriteLine("Press ENTER to hide words, type 'hint' to reveal a word, or type 'quit' to exit:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else if (input == "hint")
            {
                scripture.RevealRandomWord();
            }
            else
            {
                // Core functionality: hides 3 words at a time
                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("\nProgram closed. Keep practicing!");
    }
}