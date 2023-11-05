public class Listing : Activity
{
    private List<string> _listingList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public void ListActivity()
    {
        StartingMessage();

        SetIndex(_listingList);
        string question = UseIndex(_listingList);
        Console.WriteLine(question);
        Spinner(10);

        listing();

        endMessage();
    }
        private void listing()
    {
        stopwatch.Start();
        List<string> buf = new List<string>();
        while (stopwatch.ElapsedMilliseconds <= _activityDuration)
        {
            if(!Console.KeyAvailable)
            {
                continue;
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
            }
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        }
        Console.WriteLine();
        stopwatch.Stop();
    }
}