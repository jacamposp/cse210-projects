using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Beginner Guitar Chords in 10 Minutes", "StrumSchool", 600);
        video1.AddComment(new Comment("Diego", "Finally I can play my first song!"));
        video1.AddComment(new Comment("Rachel", "My fingers hurt but it's worth it."));
        video1.AddComment(new Comment("Kevin", "Can you do a video on barre chords next?"));
        videos.Add(video1);

        Video video2 = new Video("Easy Meal Prep for the Week", "FitKitchen", 845);
        video2.AddComment(new Comment("Paola", "This saved me so much money on takeout."));
        video2.AddComment(new Comment("Brian", "How long does the chicken last in the fridge?"));
        video2.AddComment(new Comment("Sofia", "Love the containers you used."));
        videos.Add(video2);

        Video video3 = new Video("Building a Gaming PC Step by Step", "TechBuildsHQ", 1320);
        video3.AddComment(new Comment("Andres", "Built mine following this and it worked first try."));
        video3.AddComment(new Comment("Megan", "What thermal paste do you recommend?"));
        video3.AddComment(new Comment("Jason", "The cable management tips were gold."));
        video3.AddComment(new Comment("Valeria", "Super clear explanation, thanks!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}