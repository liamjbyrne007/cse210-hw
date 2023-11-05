using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected Stopwatch stopwatch = new Stopwatch();
    protected double acc = 0.0;
    protected Random random = new Random();
    protected int _randomIndex;
    protected void SetIndex(List<string> list)
    {
        _randomIndex = random.Next(list.Count);
    }
    protected string UseIndex(List<string> list)
    {
        string question = list[_randomIndex];
        return question;
    }
    protected int _activityDuration;
    private List<string> _activityList = new List<string>
    {
        "Breathing", "Reflection", "Listing"
    };
    private List<string> _descriptionList = new List<string>
    {
        "In this activity you will practice deep, intentional breathing to help you relax. Such a practice is effective at reducing stress and anxiety. To do this, you will slowly breath in for five seconds through your nose, then slowly breath out for five through your mouth.",
        "In this activity you will reflect on emotionally significant times in your life, and how they've helped you. You'll be asked to think about a time in your life, then given some time to think about it. After some time has passed, you will be asked to answer questions about that time until the timer is up.",    
        "In this activity you will list things of significance to you in different categories."
    };
    private List<string> _animationList = new List<string>
    {
        "|", "/", "—", "\\"
    };
    protected int _duration;
    protected bool _isTimeUp = false;
    public int SetActivityDuration()
    {
        Console.WriteLine("How long in seconds do you want to do this for?");
        string durationString = Console.ReadLine();
        int duration = int.Parse(durationString);
        _activityDuration = duration * 1000;
        return _activityDuration;
    }
    public void SetActivity(string input)
    {
        if (input == "1")
        {
            _activityName = _activityList[0];
            _activityDescription = _descriptionList[0];
        }
        else if (input == "2")
        {
            _activityName = _activityList[1];
            _activityDescription = _descriptionList[1];
        }
        else if (input == "3")
        {
            _activityName = _activityList[2];
            _activityDescription = _descriptionList[2];
        }
    }
    public string GetActivityName()
    {
        return _activityName;
    }
    public string GetActivityDescription()
    {
        return _activityDescription;
    }
    public void Spinner(int dur)
    {
        int i = 0;
        string a = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(dur);
        while (DateTime.Now < endTime)
        {
            a = _animationList[i];
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= _animationList.Count())
            {
                i = 0;
            }
        }
    }
    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity!");
        Console.WriteLine("");
        Console.WriteLine($"{_activityDescription}");
        Thread.Sleep(10000);
        Console.Clear();

    }
    public void endMessage()
    {
        Console.WriteLine($"You've just worked on a {_activityName} activity for {_activityDuration/1000} seconds.");
        Console.WriteLine();
    }

}