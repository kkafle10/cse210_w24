// Define the OutdoorGathering class to represent an outdoor gathering event
class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    // Constructor
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        WeatherForecast = weatherForecast;
    }

    // Method to generate full event details for an outdoor gathering
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}