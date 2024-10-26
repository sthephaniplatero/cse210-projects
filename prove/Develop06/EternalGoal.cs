public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) :base (name,description, points)
    {

    }
    public override void RecordEvent()
    {
        Console.WriteLine("Event recorded for Eternal Goal");

    }
    public override bool IsComplete()
    {
        return false;

    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},Eternal";
    }

    public static EternalGoal ParseFromString(string data)
    {
        var parts = data.Split(',');
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        return new EternalGoal(name, description, points);
    }
}