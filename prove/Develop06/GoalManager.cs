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
        Console.WriteLine("***Goal Manager Started***");
    

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");

    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goal Name: ");
        foreach (var goal in _goals)
        {
            Console.WriteLine("-"+ goal.GetDetailsString());
        }


    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (simple, eternal, checklist): ");
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
        else if (goalType.ToLower() == "eternal")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType.ToLower() == "checklist")
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
                    _score += goal.GetPoints(); // Assuming you implement a method to get points
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
                    // Parse the line based on the expected goal type
                    // Assuming first element is the type
                    var parts = line.Split(',');
                    string goalType = parts[0];

                    switch (goalType)
                    {
                        case "Simple":
                            _goals.Add(SimpleGoal.ParseFromString(line));
                            break;
                        case "Eternal":
                            _goals.Add(EternalGoal.ParseFromString(line));
                            break;
                        case "CheckList":
                            _goals.Add(CheckListGoal.ParseFromString(line));
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


  

 


