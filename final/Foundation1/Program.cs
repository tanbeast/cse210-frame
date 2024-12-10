using System;
using System.Collections.Generic;

class Comment{
    // Properties for Comment
    public string Name { get; }
    public string Text { get; }

    // Constructor for creating a new comment
    public Comment(string name, string text){
        Name = name;
        Text = text;
    }

    // Returns a formatted string for displaying a comment
    public override string ToString() => $"{Name}: {Text}";
}

class Video{
    // Properties for Video
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }

    // Private list that encapsulates comments
    private List<Comment> Comments { get; }

    // Constructor to initialize the video with its details
    public Video(string title, string author, int length){
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>(); // Initializes the list of comments
    }

    // Adds a comment to the video
    public void AddComment(string commenter, string commentText){
        Comments.Add(new Comment(commenter, commentText));
    }

    // Returns the number of comments for this video
    public int GetNumberOfComments() => Comments.Count;

    // Displays the video details and its comments
    public void DisplayVideoDetails(){
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");
        
        foreach (var comment in Comments){
            Console.WriteLine($"  - {comment}");
        }
        Console.WriteLine(); // Blank line between videos
    }
}

class VideoLibrary{
    // List to store all the videos in the library
    private List<Video> Videos { get; }

    // Constructor to initialize the video library
    public VideoLibrary(){
        Videos = new List<Video>();
    }

    // Adds a video to the library
    public void AddVideo(Video video){
        Videos.Add(video);
    }

    // Displays all videos in the library
    public void DisplayAllVideos(){
        foreach (var video in Videos){
            video.DisplayVideoDetails();
        }
    }
}

class Program{
    static void Main(){
        // Create a library that will store all the videos
        var videoLibrary = new VideoLibrary();

        // Create video objects and add them to the library
        var video1 = new Video("How to Learn Python", "John Doe", 300);
        video1.AddComment("Alice", "Great video! I learned a lot.");
        video1.AddComment("Bob", "Helpful tutorial, but could be faster.");
        video1.AddComment("Charlie", "Love the explanations, thank you!");

        var video2 = new Video("Top 10 Programming Languages in 2024", "Jane Smith", 250);
        video2.AddComment("Eve", "Interesting list, but I disagree with some choices.");
        video2.AddComment("Frank", "Nice video! I like the ranking.");
        video2.AddComment("Alice", "This video is very informative!");
        video2.AddComment("Bob", "I learned a lot, thanks!");

        var video3 = new Video("Machine Learning Basics", "Sara Lee", 350);
        video3.AddComment("Grace", "This was very helpful for beginners.");
        video3.AddComment("Hannah", "I want to see more examples of neural networks.");
        video3.AddComment("Ivy", "Great content, but a bit too basic for my level.");
        video3.AddComment("Jack", "Looking forward to more advanced topics!");

        // Add videos to the library
        videoLibrary.AddVideo(video1);
        videoLibrary.AddVideo(video2);
        videoLibrary.AddVideo(video3);

        // Display all the videos with their details
        videoLibrary.DisplayAllVideos();
    }
}
