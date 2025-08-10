using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }
    public void Start()
    {
        string input = "";
        while (input != "6")
        {
            Console.WriteLine("Menu Options:\n 1. Create Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
            Console.Write("What would you like to do: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                CreateGoal();
            }
            if (input == "2")
            {
                ListGoalDetails();
            }
            if (input == "3")
            {
                SaveGoals();
            }
            if (input == "4")
            {
                LoadGoals();
            }
            if (input == "5")
            {
                RecordEvent();
            }
            DisplayPlayerInfo();
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    public void ListGoalNames()
    {
        int i = 0;
        Console.WriteLine("\nGOALS:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}) {goal._shortName}");
            i++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nGOALS:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The Goal types are:\n 1. Simple Goal\n 2. Eterenal Goal\n 3. Checklist Goal");
        Console.Write("Which goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("Goal Name: ");
        string goalName = Console.ReadLine();
        Console.Write("Goal Short Description: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Goal Points: ");
        string goalPoints = Console.ReadLine();
        if (goalType == "1")
        {
            SimpleGoal sGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(sGoal);
        }
        if (goalType == "2")
        {
            EternalGoal eGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eGoal);
        }
        if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished to receive the bonus? ");
            string goalTarget = Console.ReadLine();
            Console.Write("Goal Bonus Points: ");
            string goalBonus = Console.ReadLine();
            ChecklistGoal cGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(cGoal); 
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? ");
        int i = int.Parse(Console.ReadLine());
        _score += _goals[i].RecordEvent();
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            if (parts[0] == "1")
            {
                SimpleGoal sGoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                _goals.Add(sGoal);
            }
            if (parts[0] == "2")
            {
                EternalGoal eGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eGoal);
            }
            if (parts[0] == "3")
            {
                ChecklistGoal cGoal = new ChecklistGoal(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                _goals.Add(cGoal); 
            }
        }
    }
}