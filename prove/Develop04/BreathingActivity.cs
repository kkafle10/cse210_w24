// Breathing activity class
class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
    }

    protected override void PerformActivity()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in..." : "Breathe out...");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Breathing Activity.");
        Console.WriteLine($"Duration: {duration} seconds");
    }
}

// Reflection activity class
class ReflectionActivity : MindfulnessActivity
{
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration) { }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
    }

    protected override void PerformActivity()
    {
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine(prompt);

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000); // Pause for 2 seconds
        }
    }

    protected override void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the Reflection Activity.");
        Console.WriteLine($"Duration: {duration} seconds");
    }
}