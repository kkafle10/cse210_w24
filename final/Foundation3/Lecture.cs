// Define the Lecture class to represent a lecture event
class Lecture : Event
{
    private string SpeakerName { get; set; }
    private int Capacity { get; set; }

    // Constructor
    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) 
        : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    // Method to generate full event details for a lecture
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateStandardDetails()}\nType: Lecture\nSpeaker Name: {SpeakerName}\nCapacity: {Capacity}";
    }
}

// Define the Reception class to represent a reception event
class Reception : Event
{
    private string RsvpEmail { get; set; }

    // Constructor
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RsvpEmail = rsvpEmail;
    }

    // Method to generate full event details for a reception
    public override string GenerateFullDetails()
    {
        return $"{base.GenerateStandardDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}