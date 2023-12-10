public class Comment
{
    private string commentor;
    private string comment;
    public Comment(string name, string content)
    {
        commentor = name;
        comment = content;
    }
    public void writeComment()
    {
        Console.WriteLine($"{commentor}: {comment}");
    }
}