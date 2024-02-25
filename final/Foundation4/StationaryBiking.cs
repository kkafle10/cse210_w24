class StationaryBicycle : Activity
{
    private double Speed { get; set; }

    // Constructor
    public StationaryBicycle(string date, int length, double speed) 
        : base(date, length)
    {
        Speed = speed;
    }

    // Override method to calculate and return the speed
    public override double GetSpeed()
    {
        return Speed;
    }

    // Override method to calculate and return the pace
    public override double GetPace()
    {
        return 60 / Speed; // Pace in minutes per mile
    }

    // Override method to generate a summary string with all information
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {Speed} mph, Pace: {GetPace()} min/mile";
    }
}
