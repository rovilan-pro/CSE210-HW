using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Sample 1
        Video video1 = new Video("Car Chase", "Toby Parker", 160);
        video1.AddComment(new Comment("Joe Rogers", "Crazy Chase"));
        video1.AddComment(new Comment("Justin Justin", "Unbelievable!"));
        //Sample 2
        Video video2 = new Video("Memes", "Meman Maner", 60);
        video2.AddComment(new Comment("Mewtwo", "Meowers"));
        
        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}