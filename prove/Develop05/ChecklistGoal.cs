// Checklist goal class
public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        completedCount = 0;
    }

    public override void RecordEvent()
    {
        completedCount++;
        Value += 50;

        if (completedCount == targetCount)
        {
            Value += 500;
            Completed = true;
        }
    }

    public string GetProgress()
    {
        return $"Completed {completedCount}/{targetCount} times";
    }
}
