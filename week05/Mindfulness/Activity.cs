using System;
using System.Threading;

namespace Mindfulness
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0;
        }

        public string GetName() => _name;
        public int GetDuration() => _duration;

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive integer for your duration: ");
            }

            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
            Console.WriteLine();
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            ShowSpinner(4);
        }

        public void ShowSpinner(int seconds)
        {
            string[] spinnerFrames = { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                string frame = spinnerFrames[i % spinnerFrames.Length];
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");
                i++;
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);

                // Handle single vs multi-digit backspaces cleanly
                int length = i.ToString().Length;
                for (int b = 0; b < length; b++)
                {
                    Console.Write("\b \b");
                }
            }
        }
    }
}