using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video ();
        video1._title = "C# Tutorial";
        video1._author = "JC Freeman";
        video1._lengthSecond = 800;

        video1.AddComment(new Comment("Susan","Great video!"));
        video1.AddComment(new Comment("Charlie","Very informative, thanks!"));
        video1.AddComment(new Comment("Jacob","I learned a lot!"));

        // Display video information and comments
        video1.DisplayResult();

        // Get the number of comments
        Console.WriteLine($"Number of comments: {video1.GetCommentCount()}");
        Console.WriteLine("------------------------------------------------------------------------------------------------");
        

        Video video2 = new Video ();
        video2._title = "10 Ways To Get Better At Coding";
        video2._author = "Keep on coding";
        video2._lengthSecond = 600;

        video2.AddComment(new Comment("Kevanbater","Side projects have really helped me with my coding skills!"));
        video2.AddComment(new Comment("Avaragehelper","Twitch-coding? That’s probably the best idea!"));
        video2.AddComment(new Comment("Scott Madday","Side projects, especially difficult but fun ones"));

        // Display video information and comments
        video2.DisplayResult();

        // Get the number of comments
        Console.WriteLine($"Number of comments: {video2.GetCommentCount()}");
        Console.WriteLine("------------------------------------------------------------------------------------------------");

        Video video3 = new Video ();
        video3._title = "The Chosen Music Video | Healer";
        video3._author = "Firm in the Faith";
        video3._lengthSecond = 181;

        video3.AddComment(new Comment("Taygray1250","God is so good to us."));
        video3.AddComment(new Comment("Cristina Coideiro","Jesus is always by our side!"));
        video3.AddComment(new Comment("Terry m-x6","Can listen and watch this over and over!!!"));
        video3.AddComment(new Comment("Sussyp","I so love watching jonathan portraying our beautiful saviour."));

        // Display video information and comments
        video3.DisplayResult();

        // Get the number of comments
        Console.WriteLine($"Number of comments: {video3.GetCommentCount()}");
        Console.WriteLine("------------------------------------------------------------------------------------------------");

        


  
  

    }
}