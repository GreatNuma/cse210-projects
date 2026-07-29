using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() 
            : base("Breathing Activity", 
                   "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(GetDuration());

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in... ");
                ShowBreathingAnimation(4, isInhaling: true);
                Console.WriteLine();

                // Check remaining time before proceeding to exhale
                if (DateTime.Now >= endTime) break;

                Console.Write("Breathe out...");
                ShowBreathingAnimation(6, isInhaling: false);
                Console.WriteLine("\n");
            }

            DisplayEndingMessage();
        }

        /// <summary>
        /// Visual enhancement: Animates an expanding or contracting progress bar.
        /// </summary>
        private void ShowBreathingAnimation(int seconds, bool isInhaling)
        {
            int steps = seconds * 2; // Update twice a second
            int interval = 500;

            for (int i = 1; i <= steps; i++)
            {
                int barCount = isInhaling ? i : (steps - i + 1);
                string bar = new string('■', Math.Max(1, barCount));

                Console.Write($" [{bar}]");
                Thread.Sleep(interval);

                // Erase rendered string
                string backspaces = new string('\b', bar.Length + 3);
                string spaces = new string(' ', bar.Length + 3);
                Console.Write(backspaces + spaces + backspaces);
            }
        }
    }
}