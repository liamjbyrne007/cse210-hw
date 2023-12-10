public class Gathering : Event
{
    protected string _forecast;
    public void setWeather(string forecast)
    {
        _forecast = forecast;
    }
    public override void fullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine(_description);
        Console.WriteLine($"{_time} {_date}");
        Console.WriteLine($"Weather: {_forecast}");
        Console.WriteLine(_address);
    }
} 