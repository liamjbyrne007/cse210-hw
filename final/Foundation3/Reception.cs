public class Reception : Event
{
    protected string _registration;
    protected int _registrationPeriod;
    protected string _venueName;
    public void setReception(string rsvp, int rsvpTime, string venue)
    {
        _registration = rsvp;
        _registrationPeriod = rsvpTime;
        _venueName = venue;
    }
    public override void fullDetails()
    {
        Console.WriteLine("Full Details:");
        Console.WriteLine($"{_type}: {_title}");
        Console.WriteLine(_description);
        Console.WriteLine($"{_time} {_date}");
        Console.WriteLine($"RSVP: {_registration}");
        Console.WriteLine($"Please inform if you'll be there at least {_registrationPeriod} weeks beforehand.");
        Console.WriteLine(_venueName);
        Console.WriteLine(_address);
    }
}