public abstract class Activity
{
    protected DateTime _date{ get; set; }
    protected int _lenghtInMinutes{ get; set; }

    public Activity(DateTime date, int lenght)
    {
        _date = date;
        _lenghtInMinutes = lenght;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double  GetPace();
   
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} ({_lenghtInMinutes} min):" +
               $"Distance: {GetDistance(): F2}, Speed:{GetSpeed(): F2} Pace: {GetPace(): F2}";
    } 


}
