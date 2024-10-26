public class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points) :base(name, description,points)
    {
        _isCompleted = false;

    }

    public override void RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine("Simple goal completed");

    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_isCompleted}";
    }

    public static SimpleGoal ParseFromString(string data)
    {
        var parts = data.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool isCompleted = bool.Parse(parts[3]);
        SimpleGoal goal = new SimpleGoal(name, description, points);
        goal._isCompleted = isCompleted;
        return goal;
    }

    


}