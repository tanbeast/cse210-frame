using System;
using System.Collections.Generic;

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
