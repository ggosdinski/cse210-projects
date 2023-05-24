public class EternalGoal : Goal 
{
    public EternalGoal(string goalName, string goalDescription, int points) : base (goalName, goalDescription, points) 
    {}
    public override int RecordEvent() 
    {
        return GetPoints();
    }
    public override bool IsComplete() 
    {
        return false;
    }
    public override string GetDisplayString() 
    {
        return $"[ ] {_goalName} ({_goalDescription})";
    }
    public override string GetSaveData() 
    {
        return $"EternalGoal|{_goalName}|{_goalDescription}|{_points}";
    }
}