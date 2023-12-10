public abstract class Activity
{
    protected string activityType;
    protected int elsapsedTime;
    protected string date;
    public abstract double activityDistance();
    public abstract double activitySpeed();
    public abstract double activityPace();

    // public Activity(string type, int time, string day)
    // {
    //     activityType = type;
    //     elsapsedTime = time;
    //     date = day;
    // }
    public void displayActivity()
    {
        Console.WriteLine($"{date} {activityType} (time): Distance {activityDistance().ToString("F2")} km, Speed: {activitySpeed().ToString("F2")} kph, Pace: {activityPace().ToString("F2")} min per km");
    }
}