// Eternal goal class
public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name)
    {
    }

    public override void RecordEvent()
    {
        Value += 100;
    }
}