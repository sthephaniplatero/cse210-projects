public class Cycling : Activity
{
    private double SpeedInMph;

    public Cycling(DateTime date, int lenghtInMinutes, double speedInMph)
        : base(date, lenghtInMinutes)
    {
        SpeedInMph = speedInMph;
    }

    public override double GetDistance()
    {
        return (SpeedInMph * _lenghtInMinutes) / 60; // miles
    }

    public override double GetSpeed()
    {
        return SpeedInMph;
    }

    public override double GetPace()
    {
        return 60 / SpeedInMph;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Cycling ({_lenghtInMinutes} min): " +
               $"Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}