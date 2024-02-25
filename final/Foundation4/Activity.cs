// Define the base Activity class to represent an exercise activity
public class Activity
{
    public string Date { get; set; }
    public int Length { get; set; }

    // Constructor
    public Activity(string date, int length)
    {
        Date = date;
        Length = length;
    }

    // Method to calculate and return the distance covered
    public virtual double GetDistance()
    {
        return 0; // Placeholder implementation
    }

    // Method to calculate and return the speed
    public virtual double GetSpeed()
    {
        return 0; // Placeholder implementation
    }

    // Method to calculate and return the pace
    public virtual double GetPace()
    {
        return 0; // Placeholder implementation
    }

    // Method to generate a summary string with all information
    public virtual string GetSummary()
    {
        return $"Summary: {Date} - Exercise for {Length} minutes";
    }
}