public class Swimming : Activity
{
    private int Laps;
    private const double LapLengthInMeters = 50;

    public Swimming(DateTime date, int lenghtInMinutes, int laps)
        : base(date, lenghtInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * LapLengthInMeters / 1000 * 0.62; // millas
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lenghtInMinutes) * 60; // mph
    }

    public override double GetPace()
    {
        return _lenghtInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_lenghtInMinutes} min): " +
               $"Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}