using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _unusedPrompts;
        private Random _random;

        public ListingActivity() 
            : base("Listing Activity", 
                   "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _random = new Random();

            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt peace or inspiration this week?",
                "Who are some of your personal heroes?"
            };

            _unusedPrompts = new List<string>(_prompts);
        }

        public void Run()
        {
            DisplayStartingMessage();

            string prompt = GetUniquePrompt();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            List<string> userItems = GetListFromUser(GetDuration());

            Console.WriteLine($"\nYou listed {userItems.Count} items!");
            DisplayEndingMessage();
        }

        private List<string> GetListFromUser(int durationSeconds)
        {
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(durationSeconds);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                
                // Read input line
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    items.Add(input.Trim());
                }
            }

            return items;
        }

        private string GetUniquePrompt()
        {
            if (_unusedPrompts.Count == 0)
            {
                _unusedPrompts = new List<string>(_prompts);
            }
            int index = _random.Next(_unusedPrompts.Count);
            string selected = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return selected;
        }
    }
}