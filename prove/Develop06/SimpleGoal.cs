public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points) :base(name, description,points)
    {
        _isCompleted = false;

    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    

    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_isCompleted}";
    }
}