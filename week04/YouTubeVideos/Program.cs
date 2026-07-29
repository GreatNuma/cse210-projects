using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to hold all video objects
            List<Video> videos = new List<Video>();

            // ==================== VIDEO 1 ====================
            Video video1 = new Video("C# Abstraction Explained in 10 Minutes", "Tech Academy", 600);
            video1.AddComment(new Comment("Sarah", "Great explanation of abstraction!"));
            video1.AddComment(new Comment("Naomi", "This made C# classes so easy to understand."));
            video1.AddComment(new Comment("Ralphael", "Can you make a video on encapsulation next?"));
            videos.Add(video1);

            // ==================== VIDEO 2 ====================
            Video video2 = new Video("Exploring Zuma Rock & Abuja", "Travel Vlog", 840);
            video2.AddComment(new Comment("David", "The drone footage is breathtaking!"));
            video2.AddComment(new Comment("Denyefa", "Proud of Nigeria! Loved this tour."));
            video2.AddComment(new Comment("Aizen", "Adding this spot to my travel wishlist."));
            video2.AddComment(new Comment("Ichigo", "Amazing video quality!"));
            videos.Add(video2);

            // ==================== VIDEO 3 ====================
            Video video3 = new Video("Easy Homemade Sourdough Bread", "Chef Martha", 450);
            video3.AddComment(new Comment("Hannah", "Mine turned out super crusty and delicious."));
            video3.AddComment(new Comment("Ian", "What type of flour works best for this?"));
            video3.AddComment(new Comment("Julia", "Hands down the best bread tutorial on YouTube."));
            videos.Add(video3);

            // ==================== DISPLAY ALL VIDEOS ====================
            foreach (Video video in videos)
            {
                Console.WriteLine("==================================================");
                Console.WriteLine($"Title:              {video.GetTitle()}");
                Console.WriteLine($"Author:             {video.GetAuthor()}");
                Console.WriteLine($"Length:             {video.GetLengthInSeconds()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  * {comment.GetCommenterName()}: \"{comment.GetText()}\"");
                }

                Console.WriteLine("==================================================\n");
            }
        }
    }
}