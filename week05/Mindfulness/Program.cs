using System;

namespace Mindfulness
{
    // =========================================================================================
    // MY EXCEEDING REQUIREMENTS DESCRIPTION:
    // 1. Session Activity Tracker (ActivityLog.cs): Maintained an in-memory session log that tracks
    //    the frequency and total duration (in seconds) spent across all activities during the run,
    //    accessible via option 4 in the main menu.
    // 2. Non-Repeating Random Selection: Implemented a pool system in ReflectingActivity and
    //    ListingActivity to guarantee that no prompts or questions repeat until all available items
    //    in the list have been displayed at least once.
    // 3. Dynamic Visual Breathing Indicator: Enhanced the BreathingActivity display with an expanding
    //    and contracting progress bar ([■■■■■]) synchronized with countdown timing.
    // =========================================================================================

    class Program
    {
        static void Main(string[] args)
        {
            ActivityLog log = new ActivityLog();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. View session activity summary (Extra Feature)");
                Console.WriteLine("  5. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        log.LogSession(breathing.GetName(), breathing.GetDuration());
                        break;

                    case "2":
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        log.LogSession(reflecting.GetName(), reflecting.GetDuration());
                        break;

                    case "3":
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        log.LogSession(listing.GetName(), listing.GetDuration());
                        break;

                    case "4":
                        log.DisplayLog();
                        break;

                    case "5":
                        keepRunning = false;
                        Console.WriteLine("\nThank you for using the Mindfulness Program. Have a peaceful day!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}