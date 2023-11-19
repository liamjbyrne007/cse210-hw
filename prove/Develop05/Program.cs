using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Goal Program!");
        string input = "";
        Goals goals = new Goals();
        while (input != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Progress");
            Console.WriteLine("  6. Quit");
            Thread.Sleep(2000);
            Console.Write("Select a choice: ");
            input = Console.ReadLine();
            Console.Clear();
            if (input == "1")
            {
                string gT = Menu();
                if (gT == "1")
                {
                    string goalType = "Simple Goal";
                    Simple s = new Simple();
                    s.SetGoalType(goalType);
                    string simple = s.getGoal();
                    goals.AddToList(simple);
                }
                else if (gT == "2")
                {
                    string goalType = "Eternal Goal";
                    Eternal e = new Eternal();
                    e.SetGoalType(goalType);
                    string eternal = e.getGoal();
                    goals.AddToList(eternal);
                }
                else if (gT == "3")
                {
                    string goalType = "Repeating Goal";
                    Repeating r = new Repeating();
                    r.SetGoalType(goalType);
                    string repeat = r.getGoal();
                    goals.AddToList(repeat);
                }
            }
            else if (input == "2")
            {
                goals.listGoals();
            }
            else if (input == "3")
            {
                Console.WriteLine("What txt file would you like to save your goals to?");
                string file = Console.ReadLine();
                goals.saveGoals(file);
            }
            else if (input == "4")
            {
                Console.WriteLine("What txt file would you like to load your goals from?");
                string file = Console.ReadLine();
                goals.loadGoals(file);
            }
            else if (input == "5")
            {
                Console.WriteLine("Which number goal do you want to complete?");
                string number = Console.ReadLine();
                goals.AddPoints(number);
            }
        }
    string Menu()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Repeating Goal");
        Console.Write("Please input your choice: ");
        string choice = Console.ReadLine();
        Thread.Sleep(1500);
        Console.Clear();
        return choice;
    }
    }
}