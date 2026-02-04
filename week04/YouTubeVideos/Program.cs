using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basics Tutorial", "Code Academy", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "I finally understand classes."));

        Video video2 = new Video("Object-Oriented Programming", "Tech World", 900);
        video2.AddComment(new Comment("Diana", "Nice examples."));
        video2.AddComment(new Comment("Evan", "Clear and simple."));
        video2.AddComment(new Comment("Frank", "This helped me a lot."));

        Video video3 = new Video("Abstraction in C#", "Dev School", 750);
        video3.AddComment(new Comment("Grace", "Excellent content."));
        video3.AddComment(new Comment("Henry", "Good pacing."));
        video3.AddComment(new Comment("Isabella", "Very well explained."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
