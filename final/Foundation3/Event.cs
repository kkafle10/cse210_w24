// Define the base Event class to represent an event
class Event
{
    private string Title { get; set; }
    private string Description { get; set; }
    private string Date { get; set; }
    private string Time { get; set; }
    private Address Address { get; set; }

    // Constructor
    public Event(string title, string description, string date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    // Method to generate standard event details
    public string GenerateStandardDetails()
    {
        return $"Standard Details:\nTitle: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\n{Address.GetAddressString()}";
    }

    // Method to generate full event details
    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    // Method to generate short event description
    public string GenerateShortDescription()
    {
        return $"Short Description:\nType: {GetType().Name}\nTitle: {Title}\nDate: {Date}";
    }
}