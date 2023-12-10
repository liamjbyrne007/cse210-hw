using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Example of running");
        Running run = new Running("Running", 30, "Dec 09 2024", 2.5);
        run.displayActivity();
        Console.WriteLine("————————————————————————————————————————————————————————————————————");
        Console.WriteLine("Example of swimming");
        Swimming swim = new Swimming("Swimming", 45, "Nov 03 2023", 25);
        swim.displayActivity();
        Console.WriteLine("————————————————————————————————————————————————————————————————————");
        Console.WriteLine("Example of cycling");
        Biking biking = new Biking("Biking", 60, "Jun 06 1989", 12);
        biking.displayActivity();
    }
}