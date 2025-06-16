using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
 {
    string choice = "";
    while (choice != "8")
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goal Names");
        Console.WriteLine("3. List Goal Details");
        Console.WriteLine("4. Save Goals");
        Console.WriteLine("5. Load Goals");
        Console.WriteLine("6. Record Event");
        Console.WriteLine("7. Display Player Info");
        Console.WriteLine("8. Quit");

        Console.Write("Select an option: ");
        choice = Console.ReadLine();

        Console.WriteLine($"You entered '{choice}'");

        switch (choice)
        {
            case "1":
                Console.WriteLine("Creating goal");
                CreateGoal();
                break;
            case "2":
                Console.WriteLine("Listing names");
                ListGoalNames();
                break;
            case "3":
                Console.WriteLine("Listing details");
                ListGoalDetails();
                break;
            case "4":
                Console.WriteLine("Saving goals");
                SaveGoals();
                break;
            case "5":
                Console.WriteLine("Loading goals");
                LoadGoals();
                break;
            case "6":
                Console.WriteLine("Recording event");
                RecordEvent();
                break;
            case "7":
                Console.WriteLine("Displaying info");
                DisplayPlayerInfo();
                break;
            case "8":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
{
    Console.WriteLine("\nYour Goals:");
    if (_goals.Count == 0)
    {
        Console.WriteLine(" (no goals yet)");
    }
    else
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
}

    public void ListGoalDetails()
{
    Console.WriteLine("\nGoal Details:");
    if (_goals.Count == 0)
    {
        Console.WriteLine(" (no goal details available)");
    }
    else
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
}

    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("Enter short name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                Console.WriteLine("Recording Response.");
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                Console.WriteLine("Recording Response.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, desc, points, target, bonus, 0));
                Console.WriteLine("Recording Response.");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index -= 1;
            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                goal.RecordEvent();
                _score += goal.GetPoints();

                if (goal is CheckListGoal checklist && checklist.IsComplete())
                {
                    _score += checklist.GetBonus();
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save to: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "CheckListGoal":
                        _goals.Add(new CheckListGoal(data[0], data[1], int.Parse(data[2]),
                         int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                        break;
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}