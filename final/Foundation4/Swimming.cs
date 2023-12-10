public class Swimming : Activity
{
    private int _laps;
    public Swimming(string type, int time, string day, int laps)
    {
    activityType = type;
    elsapsedTime = time;
    date = day;
    _laps = laps;
    }
    public override double activityDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double activitySpeed()
    {
        return activityDistance() / elsapsedTime * 60;
    }
    public override double activityPace()
    {
        return elsapsedTime / activityDistance();
    }
}