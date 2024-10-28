using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 15), 45, 3.0),
            new Cycling(new DateTime(2024, 11, 15), 30, 12.0),
            new Swimming(new DateTime(2024, 11, 15), 60, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}