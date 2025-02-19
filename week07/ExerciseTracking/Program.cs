using System;

class Program
{
    static void Main(string[] args)
    {
    DateTime currentDate = DateTime.Today;
    List<Activity> activities = new List<Activity>
        {
            new Running(currentDate, 30, 4.8),
            new Cycling(currentDate, 45, 20.0),
            new Swimming(currentDate, 25, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
