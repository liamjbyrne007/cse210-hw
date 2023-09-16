using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letterGrade = "";

        if (percent >= 90)
        {
            letterGrade = "A";
        }
        else if (percent < 90 && percent >= 80)
        {
            letterGrade = "B";
        }
        else if (percent < 80 && percent >= 70)
        {
            letterGrade = "C";
        }
        else if (percent < 70 && percent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your grade is {letterGrade}");
        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Good job, you have passed.");
        }
        else if (letterGrade == "D" || letterGrade == "F")
        {
            Console.WriteLine("You failed.");
        }
    }
}