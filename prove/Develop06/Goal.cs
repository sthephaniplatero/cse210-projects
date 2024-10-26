using System.Collections.Generic;
using System.IO;

public class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {
        _isCompleted = true;

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        string status = _isCompleted ? "[x]" : "[ ]";
        return $"{status} {_shortName}: {_description} ({_points} points)";
    }
    

    public virtual string GetStringRepresentation()
    {
        return $"{this.GetType().Name}{_shortName},{_description},{_points}{_isCompleted},";
    }
}