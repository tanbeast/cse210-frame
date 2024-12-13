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