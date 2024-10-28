public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int lenghtInMinutes, double distanceInMiles)
        : base(date, lenghtInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    public override double GetSpeed()
    {
        return (_distanceInMiles / _lenghtInMinutes) * 60; 
    }

    public override double GetPace()
    {
        return _lenghtInMinutes / _distanceInMiles;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running ({_lenghtInMinutes} min): " +
               $"Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}
