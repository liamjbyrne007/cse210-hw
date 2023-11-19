using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

public class Goals
{
    protected string _goalType;
    protected string _goalName;
    protected string _goalDesc;
    protected int _completionPoints;
    protected bool _goalComplete;
    protected List<string> _goals;
    protected string _typePrompt;
    protected int _totalPoints;
    protected int i = 0;
    public Goals()
    {
        _goals = new List<string>();
    }
    public void Menu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Repeating Goal");
        Console.Write("Please input your choice: ");
        string choice = Console.ReadLine();
    }
    public void AddToList(string goal)
    {
        _goals.Add(goal);
    }
    
    public virtual string getGoal()
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
        Console.WriteLine("How many points should you receive when you complete it?");
        _completionPoints = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Goal Type: {_goalType}\nGoal Name: {_goalName}\nGoal Description: {_goalDesc}\nGoal Points: {_completionPoints}");
        Console.WriteLine("Great! You have added a goal to your list!");
        _goalComplete = false;
        Thread.Sleep(5000);
        Console.WriteLine("Great! You have added a goal!");
        return $"{_goalType},{_goalComplete},{_goalName},{_goalDesc},{_completionPoints}";
    }
    
    public void loadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints = int.Parse(lines[0]);
        
        foreach (string goal in lines.Skip(1))
        {
            AddToList(goal);
        }
    }
    public void saveGoals(string fileName)
    {
        Console.WriteLine("Saving goals to file.");
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine(_totalPoints);
            foreach (string g in _goals)
            {
                sw.WriteLine(g);
            }
        }
    }
    // public virtual void recordGoal(string goal)
    // {
    //     string [] fields = goal.Split(",");
    //     _goalType = fields[0];
    //     if (_goalType == "Simple Goal")
    //     {

    //     }
    // }
    public virtual void listGoals()
    {
        Console.WriteLine($"Total Earned Points: {_totalPoints}");
        foreach (var goal in _goals)
        {
            string [] fields = goal.Split(",");
            _goalType = fields[0];
            i++;
            if (_goalType == "Simple Goal" || _goalType == "Eternal Goal")
            {
                PrintGoal(goal);
            }
            else if (_goalType == "Repeating Goal")
            {
                Repeating pr = new Repeating();
                pr.PrintGoal(goal);
            }
        }
    }
    public void AddPoints(string number)
    {
        int gN = int.Parse(number);
        gN -= 1;
        string goal = _goals[gN];
        string [] fields = goal.Split(",");
        _goalType = fields[0];
        _completionPoints = int.Parse(fields[4]);
        _goalName = fields[2];
        _goalComplete = bool.Parse(fields[1]);
        if (_goalType == "Simple Goal")
        {
            _totalPoints += _completionPoints;
            _goalComplete = true;
        }
        else if (_goalType == "Eternal Goal")
        {
            _totalPoints += _completionPoints;
        }
        else if (_goalType == "Repeating Goal")
        {
            int finishPoints = int.Parse(fields[5]);
            int repetitions = int.Parse(fields[6]);
            int totalRepetitions = int.Parse(fields[7]);
            repetitions += 1;
            _totalPoints += _completionPoints;
            if (repetitions == totalRepetitions)
            {
                _totalPoints += finishPoints;
            }
        }
        
    }
    protected virtual void PrintGoal(string g)
    {
        string completion = " ";
        string[] fields = g.Split(",");
        string goalType = fields[0];
        bool goalComplete = bool.Parse(fields[1]);
        string goalName = fields[2];
        string goalDesc = fields[3];
        int completionPoints = int.Parse(fields[4]);
        if (goalComplete == true)
        {
            completion = "X";
        }
        Console.WriteLine($"{i}. Completed: [{completion}]; Goal Type: {goalType}; {goalName}: {goalDesc}. Completion Points: {completionPoints}");
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
}