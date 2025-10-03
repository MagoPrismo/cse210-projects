using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //the data was create using AI
        //the videos
        Video video1 = new Video("Tech Explained", "Understanding APIs", 725.5f);
        Video video2 = new Video("DIY Creators", "How to Build a Bookshelf", 1140.0f);
        Video video3 = new Video("Kitchen Journeys", "Perfect Sourdough Bread Recipe", 982.8f);
        //the comments
        // Comments for the first video ("Understanding APIs")
        Comment comment1 = new Comment("DevDan", "This is the clearest explanation of REST APIs I've ever seen. Thank you!");
        Comment comment2 = new Comment("CuriousCoder", "Great video! Could you do a follow-up on GraphQL?");
        Comment comment3 = new Comment("Ana", "Finally, it makes sense! The real-world examples were super helpful.");
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(comment1);
        comments1.Add(comment2);
        comments1.Add(comment3);
        video1.SetComment(comments1);
        // Comments for the second video ("How to Build a Bookshelf")
        Comment comment4 = new Comment("WoodworkFan", "Just finished my bookshelf following your steps. It looks amazing!");
        Comment comment5 = new Comment("Jenna", "What kind of wood do you recommend for a beginner?");
        Comment comment6 = new Comment("Mark P.", "The tip about using a corner clamp was a game-changer. Thanks!");
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(comment4);
        comments2.Add(comment5);
        comments2.Add(comment6);
        video2.SetComment(comments2);
        // Comments for the third video ("Perfect Sourdough Bread Recipe")
        Comment comment7 = new Comment("BreadLover123", "My starter is finally active! Can't wait to try this recipe this weekend.");
        Comment comment8 = new Comment("Carlos", "My loaf came out a bit dense. Any tips for a better rise?");
        Comment comment9 = new Comment("Sophie R.", "This recipe is flawless. My family loved the bread. Best sourdough I've ever made!");
        List<Comment> comments3 = new List<Comment>();
        comments3.Add(comment7);
        comments3.Add(comment8);
        comments3.Add(comment9);
        video3.SetComment(comments3);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var item in videos)
        {
            item.DisplayAll();
        }
    }
}