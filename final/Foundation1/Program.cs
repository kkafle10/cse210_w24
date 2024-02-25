using System;
using System.Collections.Generic;


class Program
{
     static void Main(string[] args)
    {
        // Create 3-4 videos
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 300),
            new Video("Video 2", "Author 2", 240),
            new Video("Video 3", "Author 3", 180),
            new Video("Video 4", "Author 4", 420)
        };

        // Add comments to each video
        foreach (Video video in videos)
        {
            video.AddComment("User 1", "This is a great video!");
            video.AddComment("User 2", "I learned a lot from this video.");
            video.AddComment("User 3", "Could you make more videos like this?");
        }

        // Iterate through the list of videos and display information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            video.DisplayComments();
            Console.WriteLine(); // Add a blank line for separation
        }
    }
}
