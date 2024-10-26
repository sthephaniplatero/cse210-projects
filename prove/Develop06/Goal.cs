using System.Diagnostics.Tracing;

public class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Event recorded for goal");

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"Goal: {_shortName}\nDescription:{_description}\n Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}