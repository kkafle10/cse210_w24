// Simple goal class
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value) : base(name)
    {
        Value = value;
    }

    public override void RecordEvent()
    {
        if (!Completed)
        {
            Value += 100;
            Completed = true;
        }
    }
}