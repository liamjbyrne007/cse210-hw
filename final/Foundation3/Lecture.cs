public class Lecture : Event
{
    protected string _speaker;
    protected int _capacity;
    public void setLecture(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void fullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine($"{_time} {_date}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine(_description);
        Console.WriteLine($"Lecture Capacity: {_capacity} people.");
        Console.WriteLine(_address);
    }
}