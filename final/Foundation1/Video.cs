public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;
    // public void addVideo(Video video)
    // {
    //     videos.Add(video);
    // }
    public Video(string name, string maker, int duration)
    {
        title = name;
        author = maker;
        length = duration;
        comments = new List<Comment>();
    }
    public void writeVideo()
    {
        Console.WriteLine($"{title} - {length} seconds long.");
        Console.WriteLine($"By {author}");
        int commentsNumber = comments.Count();
        Console.WriteLine($"Number of comments: {commentsNumber}");
        writeComments();
    }
    public void addComments(string writer, string text)
    {
        Comment comment = new Comment(writer, text);
        comments.Add(comment);
    }
    public void writeComments()
    {
        foreach (Comment c in comments)
        {
            c.writeComment();
        }
    }
}