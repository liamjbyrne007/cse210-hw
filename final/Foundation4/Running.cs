public class Running : Activity
{
    private double _distance;
    public Running(string type, int time, string day, double length)
    {
        activityType = type;
        elsapsedTime = time;
        date = day;
        _distance = length;
    }
    public override double activityDistance()
    {
        return _distance;
    }
    public override double activitySpeed()
    {
        return _distance / elsapsedTime * 60;
    }
    public override double activityPace()
    {
        return elsapsedTime / _distance;
    }
}