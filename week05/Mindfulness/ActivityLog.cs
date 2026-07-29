using System;
using System.Collections.Generic;

namespace Mindfulness
{
    public class ActivityLog
    {
        private Dictionary<string, int> _activityCounts;
        private int _totalSecondsSpent;

        public ActivityLog()
        {
            _activityCounts = new Dictionary<string, int>
            {
                { "Breathing Activity", 0 },
                { "Reflection Activity", 0 },
                { "Listing Activity", 0 }
            };
            _totalSecondsSpent = 0;
        }

        public void LogSession(string activityName, int duration)
        {
            if (_activityCounts.ContainsKey(activityName))
            {
                _activityCounts[activityName]++;
            }
            else
            {
                _activityCounts[activityName] = 1;
            }
            _totalSecondsSpent += duration;
        }

        public void DisplayLog()
        {
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("       Session Activity Summary        ");
            Console.WriteLine("=======================================");
            
            foreach (var entry in _activityCounts)
            {
                Console.WriteLine($" • {entry.Key}: {entry.Value} session(s)");
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($" Total Mindfulness Time: {_totalSecondsSpent} seconds");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Please press Enter to return to the main menu...");
            Console.ReadLine();
        }
    }
}