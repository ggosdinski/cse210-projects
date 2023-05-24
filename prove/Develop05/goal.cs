public abstract class Goal 
{
    public string _goalName;
    public string _goalDescription;
    public int _points;
    public Goal(string goalName, string goalDescription, int points)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    // returns a bool whether goal is complete or not, determines whether an x is displayed or not
    public abstract string GetDisplayString();
    // display string for displaying goal
    public abstract string GetSaveData();
    // save data to save goal in list

    public int GetPoints() {
        return _points;
    }
}