using System;


class Program
{
    static void Main(string[] args)
    {
        // Create instances of Address for events
        Address lectureAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address receptionAddress = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Address outdoorGatheringAddress = new Address("789 Oak St", "Chicago", "IL", "USA");

        // Create instances of Lecture, Reception, and OutdoorGathering events
        Lecture lecture = new Lecture("Introduction to Programming", "Learn the basics of programming", "2024-03-15", "10:00 AM", lectureAddress, "John Doe", 100);
        Reception reception = new Reception("Networking Mixer", "Join us for networking and refreshments", "2024-03-20", "6:00 PM", receptionAddress, "info@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities and food", "2024-07-01", "12:00 PM", outdoorGatheringAddress, "Sunny with a high of 75°F");

        // Generate and display marketing messages for each event
        Console.WriteLine("Event Marketing Messages:");
        Console.WriteLine("\nLecture:");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine(lecture.GenerateShortDescription());

        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine(reception.GenerateShortDescription());

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GenerateStandardDetails());
        Console.WriteLine(outdoorGathering.GenerateFullDetails());
        Console.WriteLine(outdoorGathering.GenerateShortDescription());
    }
}

