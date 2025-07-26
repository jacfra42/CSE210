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

        List<Comment> video2Comments = new List<Comment>();
        video2Comments.Add(new Comment("Bj", "Nooooooo"));
        video2Comments.Add(new Comment("Tom", "clickbait ):"));
        video2Comments.Add(new Comment("Janice", "nice"));
        Video video2 = new Video("I solved world hunger", "Billy Bob", 550, video2Comments);

        List<Comment> video3Comments = new List<Comment>();
        video3Comments.Add(new Comment("Jim", "I'm 3 years old and I can tie my shoes now!"));
        video3Comments.Add(new Comment("Huey", "Just use velcro"));
        video3Comments.Add(new Comment("Manny", "I wish I knew this sooner, thanks UrMom"));
        Video video3 = new Video("How to Tie your Shoe", "UrMom", 8394, video3Comments);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
        }
    }
}