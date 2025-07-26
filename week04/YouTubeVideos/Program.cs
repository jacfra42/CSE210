using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> video1Comments = new List<Comment>();
        video1Comments.Add(new Comment("Bill", "Good Job!"));
        video1Comments.Add(new Comment("Timmy", "I love your videos"));
        video1Comments.Add(new Comment("Jill", "lol"));
        Video video1 = new Video("Yolo", "Mr. Beast", 600, video1Comments);
        Console.WriteLine(video1.GetDisplayText());
    }
}