using System;

class Program
{
    static void Main(string[] args)
    {
  List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Basic", "John Daf", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Jerry", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charles", "I finally understand this topic!"));
        video1.AddComment(new Comment("Jey", "I need another concept please for proper clarification!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C#", "Janet Don", 900);
        video2.AddComment(new Comment("Dave", "This was a bit complex but useful."));
        video2.AddComment(new Comment("Eli", "Thanks for making it simplier!"));
        video2.AddComment(new Comment("Tom", "Could you do a video on async programming?"));
        videos.Add(video2);

        Video video3 = new Video("GitHub Clip", "Emma David", 720);
        video3.AddComment(new Comment("Oluwayemi", "GitHub is interetsing!"));
        video3.AddComment(new Comment("Helen", "This made GitHib easy to understand."));
        video3.AddComment(new Comment("Oluwabukola", "Looking forward to more tutorials."));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
