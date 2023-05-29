using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> _videos = new List<Video>();

        // video 1
        Video video1 = new Video("Learn Python in 10 minutes", "Ggosdinski", 600);
        video1.Comment("Frank2023", "Nice video!");
        video1.Comment("LuisFernandez", "Thank you!");
        video1.Comment("EmmaMuñoz", "Great content!");
        _videos.Add(video1);

        Video video2 = new Video("Classes in C#", "Ggosdinski", 1893);
        video2.Comment("MarielaOrtega", "Thank you for sharing this with us");
        video2.Comment("GerssonFlores", "Where can I contact you?");
        video2.Comment("MelissaCardenas", "Very good video");
        _videos.Add(video2);

        Video video3 = new Video("Learn the basics of SQL", "Ggosdinski", 980);
        video3.Comment("FreddyGarcia", "Excelent video!");
        video3.Comment("Cecilia5480", "I finally understand SQL");
        video3.Comment("Russel203", "Very informative");
        _videos.Add(video3);

        foreach(Video video in _videos) {
            video.Print();
        }
    }
}