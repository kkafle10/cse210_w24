using System;


class Program
{
    static void Main(string[] args)
    {
        // Create instances of Running, StationaryBicycle, and Swimming classes
        Running running = new Running("03 Nov 2022", 30, 3.0);
        StationaryBicycle bicycle = new StationaryBicycle("03 Nov 2022", 30, 10.0);
        Swimming swimming = new Swimming("03 Nov 2022", 30, 20);

        // Put each activity in the same list
        Activity[] activities = { running, bicycle, swimming };

        // Iterate through the list and call the GetSummary method on each item
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}