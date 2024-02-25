// Define the Running class to represent a running activity
public class Running : Activity
{
    private double Distance { get; set; }

    // Constructor
    public Running(string date, int length, double distance) 
        : base(date, length)
    {
        Distance = distance;
    }

    // Override method to calculate and return the distance covered
    public override double GetDistance()
    {
        return Distance;
    }

    // Override method to calculate and return the speed
    public override double GetSpeed()
    {
        return Distance / (Length / 60); // Speed in miles per hour
    }

    // Override method to calculate and return the pace
    public override double GetPace()
    {
        return Length / Distance; // Pace in minutes per mile
    }

    // Override method to generate a summary string with all information
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}
