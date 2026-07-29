using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        private List<string> _unusedPrompts;
        private List<string> _unusedQuestions;
        private Random _random;

        public ReflectingActivity() 
            : base("Reflection Activity", 
                   "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _random = new Random();

            _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind, in the future?"
            };

            _unusedPrompts = new List<string>(_prompts);
            _unusedQuestions = new List<string>(_questions);
        }

        public void Run()
        {
            DisplayStartingMessage();

            string prompt = GetUniquePrompt();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"\n --- {prompt} --- \n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                string question = GetUniqueQuestion();
                Console.Write($"> {question} ");
                ShowSpinner(7);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }

        private string GetUniquePrompt()
        {
            if (_unusedPrompts.Count == 0)
            {
                _unusedPrompts = new List<string>(_prompts); // Reset pool when exhausted
            }
            int index = _random.Next(_unusedPrompts.Count);
            string selected = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);
            return selected;
        }

        private string GetUniqueQuestion()
        {
            if (_unusedQuestions.Count == 0)
            {
                _unusedQuestions = new List<string>(_questions); // Reset pool when exhausted
            }
            int index = _random.Next(_unusedQuestions.Count);
            string selected = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);
            return selected;
        }
    }
}