using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        string input = "";
        while (input != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Please input your choice: ");
            input = Console.ReadLine();
            Console.Clear();

            if (input == "1")
            {
                Breathing b = new Breathing();
                b.SetActivity(input);
                b.SetActivityDuration();
                b.breathingActivity();
            }
            else if (input == "2")
            {
                Reflection r = new Reflection();
                r.SetActivity(input);
                r.SetActivityDuration();
                r.reflect();
            }
            else if (input == "3")
            {
                Listing l = new Listing();
                l.SetActivity(input);
                l.SetActivityDuration();
                l.ListActivity();
            }
        }
    }
}