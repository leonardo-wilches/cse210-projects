using System;

class Program
{
    //Leonardo Wilches - W04 Assignment: YouTube Video Program (Foundation #1)

    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn how to play guitar", "Music Academy", 600);
        video1.AddComment(new Comment("Leonardo", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I love this lessons"));
        videos.Add(video1);

        Video video2 = new Video("How to bake cookies", "Cookies World", 420);
        video2.AddComment(new Comment("David", "Looks delicious!"));
        video2.AddComment(new Comment("Eva", "I tried it and it was amazing."));
        video2.AddComment(new Comment("Stephen", "Can you do a oatmeal cookies?"));
        videos.Add(video2);

        Video video3 = new Video("Travel to Japan", "World Travels", 900);
        video3.AddComment(new Comment("Grace", "Japan is beautiful!"));
        video3.AddComment(new Comment("Henry", "I like this country!!"));
        video3.AddComment(new Comment("James", "What season is best to travel?"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}