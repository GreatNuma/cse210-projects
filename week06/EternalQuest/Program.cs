using System;

// EXCEEDING REQUIREMENTS:
// 1. Hello, i added a "NegativeGoal" class to track bad habits. When recorded, it subtracts points from the user's score.
// 2.  I Implemented a "Title/Rank" system in the GoalManager. As the user gains points, they level up and 
//    gain new titles (e.g., Novice, Apprentice, Knight, Master) which are displayed next to their score.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}