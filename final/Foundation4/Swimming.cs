// Define the Swimming class to represent a swimming activity
public class Swimming : Activity
{
    private int Laps { get; set; }

    // Constructor
    public Swimming(string date, int length, int laps) 
        : base(date, length)
    {
        Laps = laps;
    }

    // Override method to calculate and return the distance covered
    public override double GetDistance()
    {
        return Laps * 50 / 1000; // Distance in kilometers
    }

    // Override method to calculate and return the speed
    public override double GetSpeed()
    {
        return GetDistance() / (Length / 60); // Speed in kilometers per hour
    }

    // Override method to calculate and return the pace
    public override double GetPace()
    {
        return Length / GetDistance(); // Pace in minutes per kilometer
    }

    // Override method to generate a summary string with all information
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
