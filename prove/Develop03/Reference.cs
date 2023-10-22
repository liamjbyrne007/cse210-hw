using System.Diagnostics.Contracts;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;
    private List<string> _references = new List<string>()
    {
        "2 Nephi 2:15",
        "John 14:26-27",
        "Matthew 3:15-17",
        "Mosiah 2:41",
        "3 Nephi 11:10-11"
    };
    public string getReference(int rnd)
    {
        return _references[rnd];
    }
}
