using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity> {
            new Running("2024-02-20", 30, 3.0),
            new Running("2024-02-20", 30, 4.8),
            new Cycling("2024-02-21", 45, 15),
            new Swimming("2024-02-22", 60, 20)
        };

        foreach (Activity activity in activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }
}