using System.Runtime.CompilerServices;
using System.Diagnostics;

public class Reflection : Activity
{
    private List<string> _topic = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _question = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public void reflect()
    {
        StartingMessage();

        SetIndex(_topic);
        string topic = UseIndex(_topic);
        Console.WriteLine($"{topic}");
        Spinner(10);

        reflectQuesion();       

        endMessage();
    }

    private void reflectQuesion()
    {
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds <= _activityDuration)
        {
            SetIndex(_question);
            string question = UseIndex(_question);
            Console.WriteLine($"{question}");
            Spinner(10);
        }
        Console.WriteLine();
        stopwatch.Stop();
    }
}