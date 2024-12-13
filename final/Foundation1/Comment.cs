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
