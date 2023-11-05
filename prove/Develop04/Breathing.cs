public class Breathing : Activity
{
    public void breathingActivity()
    {
        StartingMessage();
        Thread.Sleep(10000);
        Console.Clear();

        breathingTiming();

        endMessage();
    }
    private void breathingTiming()
    {
        stopwatch.Start();
        // List<string> buf = new List<string>();
        while (stopwatch.ElapsedMilliseconds <= _activityDuration)
        {

            breathIn(10);
        }
        Console.WriteLine();
        stopwatch.Stop();
    }
    private void breathIn(int time)
    {
        Console.WriteLine("Breath in");
        for (int i = time / 2; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Breath out");
        Console.Write(".....");
        for (int i = time / 2; i > 0; i--)
        {
            Console.Write("\b \b");
            Thread.Sleep(1000);
        }
        Console.Clear();
    }
}