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