// Base class for all types of goals
public abstract class Goal
{
    public string Name { get; }
    public int Value { get; protected set; }
    public bool Completed { get; protected set; }

    public Goal(string name)
    {
        Name = name;
        Value = 0;
        Completed = false;
    }

    // Method to record an event and update the goal's value
    public abstract void RecordEvent();
}