// Base class for mindfulness activity
public abstract class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    // Method to start the activity
    public void Start()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000); // Pause for 3 seconds

        PerformActivity();

        DisplayEndingMessage();
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Abstract methods to be implemented by derived classes
    protected abstract void DisplayStartingMessage();
    protected abstract void PerformActivity();
    protected abstract void DisplayEndingMessage();
}
