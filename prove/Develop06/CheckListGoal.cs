public class CheckListGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) :base (name, description,points)
    {
        _amountCompleted = 0;
        _bonus = bonus;
        _target = target;

    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine("Event recorded for checklist goal");

        }
        else{
            Console.WriteLine("Goal already completed.");
        }

    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;

    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()}\nProgress:{_amountCompleted}/{_target}\nBonus: {_bonus}";
        
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_target},{_bonus},{_amountCompleted}";

    }

    public static CheckListGoal ParseFromString(string data)
    {
        var parts = data.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int target = int.Parse(parts[3]);
        int bonus = int.Parse(parts[4]);
        int amountCompleted = int.Parse(parts[5]);

        CheckListGoal goal = new CheckListGoal(name, description, points, target, bonus);
        goal._amountCompleted = amountCompleted;
        return goal;
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
}


