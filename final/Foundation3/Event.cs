using System;
using System.Collections.Generic;
public abstract class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public void setdetails(string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void standardDetails()
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"{_time} {_date}");
        Console.WriteLine(_address);
    }

    public abstract void fullDetails();
    public void shortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine($"{_type, -10}: {_title}");
        Console.WriteLine(_date);
    }
}