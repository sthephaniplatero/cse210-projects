public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _isCompleted = true;
        }
    }

    public override bool IsComplete()
    {
        return _isCompleted;
    }

    public override string GetDetailsString()
    {
        string status = _isCompleted ? "[x]" : "[ ]";
        return $"{status} {_shortName}: {_description} ({_points} points, {_amountCompleted}/{_target} completed)";
    }
}