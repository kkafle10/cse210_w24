// Listing activity class
class ListingActivity : MindfulnessActivity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
    }

    protected override void PerformActivity()
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(3000); // Pause for 3 seconds

        Console.WriteLine("Begin listing items...");
        Thread.Sleep(duration * 1000); // Pause for specified duration in seconds

        Console.WriteLine("Activity completed. Total items listed: 10"); // Assuming 10 items listed for simplicity
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Listing Activity.");
        Console.WriteLine($"Duration: {duration} seconds");
    }
}