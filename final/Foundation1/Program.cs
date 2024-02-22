using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Music", "Author 1", 300);
        video1.AddComment("Jhon", "Great video!");
        video1.AddComment("Jospeh", "Thanks for the tutorial.");
        videos.Add(video1);

        Video video2 = new Video("Documental", "Author 2", 400);
        video2.AddComment("Charlie", "Very informative.");
        video2.AddComment("David", "Could you cover more examples?");
        video2.AddComment("Eve", "I didn't understand the last part.");
        videos.Add(video2);

        Video video3 = new Video("Space travel", "Author 3", 500);
        video3.AddComment("Maty", "Nicely done!");
        video3.AddComment("Stephen", "That's my brother there!");
        video3.AddComment("Jack", "I wish I could go there.");
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetInfo());
            Console.WriteLine();
        }
    }
}