// Define the Video class to represent a YouTube video
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    // Method to add a new comment to the video
    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    // Method to get the number of comments on the video
    public int GetNumComments()
    {
        return Comments.Count;
    }

    // Method to display video information
    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length + " seconds");
        Console.WriteLine("Number of Comments: " + GetNumComments());
    }

    // Method to display all comments on the video
    public void DisplayComments()
    {
        Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine("- " + comment.Name + ": " + comment.Text);
        }
    }
}
