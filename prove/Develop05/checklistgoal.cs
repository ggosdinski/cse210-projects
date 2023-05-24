public class ChecklistGoal : Goal 
{
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;
    public ChecklistGoal(string goalName, string goalDescription, int points, int timesCompleted, int timesToComplete, int bonusPoints) : base (goalName, goalDescription, points) 
    {
        _timesCompleted = timesCompleted;
        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;
    }
    public override int RecordEvent()
    {
        if (_timesCompleted < _timesToComplete) {
            int points = GetPoints();
            _timesCompleted += 1;
            if (_timesCompleted == _timesToComplete) { 
                points += _bonusPoints;
            } 
            return points;
        } else {
            return 0;
        }
    }
    public override bool IsComplete() 
    {
        if (_timesCompleted == _timesToComplete) {
            return true;
        } else {
            return false;
        }
    }
    public override string GetDisplayString() 
    {
        if (IsComplete()) {
            return $"[X] {_goalName} ({_goalDescription}) -- Currently Completed: {_timesCompleted}/{_timesToComplete}";
        } else {
            return $"[ ] {_goalName} ({_goalDescription}) {_timesCompleted}/{_timesToComplete}";
        }
    }
    public override string GetSaveData() 
    {
        return $"ChecklistGoal|{_goalName}|{_goalDescription}|{_points}|{_timesCompleted}|{_timesToComplete}|{_bonusPoints}";
    }
}