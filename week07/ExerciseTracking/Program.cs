using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 25, 4.9),
            new Cycling(new DateTime(2022, 11, 3), 40, 29.1),
            new Swimming(new DateTime(2022, 11, 3), 30, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}