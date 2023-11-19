public class Repeating : Goals
{
    private int _finishPoints;
    private int _repetitionTotal;
    private int _repetitions;
    public override string getGoal()
    {
        Console.WriteLine($"You have chosen to make a {_goalType} goal.");
        Console.WriteLine("What is the name of the goal you would like to make?");
        _goalName = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}");
        Console.WriteLine("What is a brief description of your goal?");
        _goalDesc = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}\nGoal Description: {_goalDesc}");
        Console.WriteLine("How many points should you receive when you do it once?");
        _completionPoints = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}\nGoal Description: {_goalDesc}\nGoal Points: {_completionPoints}");
        Console.WriteLine("How many points should you get when you finish it?");
        _finishPoints = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}\nGoal Description: {_goalDesc}\nGoal Points: {_completionPoints}\nGoal Completion Points: {_finishPoints}");
        Console.WriteLine("How many times do you want to do this goal?");
        _repetitionTotal = int.Parse(Console.ReadLine());
        Console.Clear(); 
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}\nGoal Description: {_goalDesc}\nGoal Points: {_completionPoints}\nGoal Completion Points: {_finishPoints}\nGoal repetitions: {_repetitionTotal}");
        _goalComplete = false;
        _repetitions = 0;
        Thread.Sleep(5000);
        Console.WriteLine("Great! You have added a goal to your list!");
        return $"{_goalType},{_goalComplete},{_goalName},{_goalDesc},{_completionPoints},{_finishPoints},{_repetitions},{_repetitionTotal}";
    }
    protected override void PrintGoal(string g)
    {
        string completion = " ";
        string[] fields = g.Split(",");
        i++;
        string goalType = fields[0];
        bool goalComplete = bool.Parse(fields[1]);
        string goalName = fields[2];
        string goalDesc = fields[3];
        int completionPoints = int.Parse(fields[4]);
        if (goalComplete == true)
        {
            completion = "X";
        }
        int finishPoints = int.Parse(fields[5]);
        int repetitions = int.Parse(fields[6]);
        int repetitionTotal = int.Parse(fields[7]);
        if (repetitions == repetitionTotal)
        {
            completion = "X";
        }
        else if (repetitions < repetitionTotal)
        {
            completion = $"{repetitions}/{repetitionTotal}";
        }
        Console.WriteLine($"{i}. Completed: [{completion}]; Goal Type: {goalType}; {goalName}: {goalDesc}. Completion Points: {completionPoints}; Finishing Points: {finishPoints}");
    }
}