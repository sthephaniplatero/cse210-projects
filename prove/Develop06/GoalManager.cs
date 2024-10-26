public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        Console.WriteLine($"You have {_score} points\n");

        while (!exit)
        {
            Console.WriteLine("*** Goal Manager ***");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    exit = true;
                    Console.WriteLine("Exiting Goal Manager. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.WriteLine();
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();
        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType.ToLower() == "simple")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType.ToLower() == "Eternal")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType.ToLower() == "Checklist")
        {
            Console.WriteLine("Enter target: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckListGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter goal name to record event: ");
        string goalName = Console.ReadLine();
        foreach (var goal in _goals)
        {
            if (goal.GetDetailsString().Contains(goalName))
            {
                goal.RecordEvent();
                if (goal.IsComplete())
                {
                    Console.WriteLine($"Congratulations! You've completed the goal: {goal.GetDetailsString()}");
                    _score += goal.GetPoints();
                }
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to goals.txt.");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    string goalType = parts[0];

                    switch (goalType)
                    {
                        case "Simple":
                            _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "Eternal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "CheckList":
                            _goals.Add(new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded from goals.txt.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}