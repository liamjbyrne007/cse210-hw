public class Biking : Activity
{
    private double _speed;
    public Biking(string type, int time, string day, double mcqueen)
    {
        activityType = type;
        elsapsedTime = time;
        date = day;
        _speed = mcqueen;
    }
    public override double activitySpeed()
    {
        return _speed;
    }
    public override double activityDistance()
    {
        return _speed * elsapsedTime / 60;
    }
    public override double activityPace()
    {
        return elsapsedTime / activityDistance();
    }
}