using System;

class Program
{
    //Leonardo Wilches - W07 Assignment: Exercise Tracking Program (Foundation #3)
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new RunningActivity(new DateTime(2025, 8, 14), 30, 5.0));
        activities.Add(new CyclingActivity(new DateTime(2025, 8, 14), 55, 25.5));
        activities.Add(new SwimmingActivity(new DateTime(2025, 8, 14), 20, 35));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}