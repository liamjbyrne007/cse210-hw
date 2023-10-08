using System.IO;

public class Entry
{
    public string Date()
    {
        DateTime entryDateTime = DateTime.Now;
        string entryDate = entryDateTime.ToShortDateString();
        return entryDate;
    }
    public string _responseDate;
    public string _responsePrompt;
    public string _response;
    public void Display()
    {
        Console.WriteLine($"{_responseDate} -- {_responsePrompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine("");
    }
}


        // Console.WriteLine($"{responseDate} -- {responsePrompt}");
        // Console.WriteLine($"{response}");
        // Console.WriteLine("");