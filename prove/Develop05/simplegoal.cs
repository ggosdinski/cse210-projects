public class SimpleGoal : Goal 
{
    private bool _complete;
    public SimpleGoal(string goalName, string goalDescription, int points, bool complete) : base(goalName, goalDescription, points) 
    {
        _complete = complete;
    }
    public override int RecordEvent() 
    {
        if (IsComplete()){
            return 0;
        } else {
            _complete = true;
            return GetPoints();
        }
    }
    public override bool IsComplete() 
    {
        return _complete;
    }
    public override string GetDisplayString() 
    {
        if (IsComplete()) {
            return $"[X] {_goalName} ({_goalDescription})";
        } else {
            return $"[ ] {_goalName} ({_goalDescription})";
        }
    }
    public override string GetSaveData() 
    {
        return $"SimpleGoal|{_goalName}|{_goalDescription}|{_points}|{_complete}";
    }
}